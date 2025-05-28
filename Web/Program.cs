using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Entity.Context;
using Utilities.Helpers;
using Data.Interfaces;
using Business.Interfaces;
using Business.Implements;
using Utilities.Interfaces;
using Utilities.Mail;
using Utilities.Jwt;
using Web.ServiceExtension;
using FluentValidation;
using Business.Services;
using Data.Implements.BaseData;
using Data.Implements.Security.UserDate;
using Data.Interfaces.Security;
using Data.Implements.Security.RolUserData;
using Data.Implements.Security.RolData;



var builder = WebApplication.CreateBuilder(args);

// Add controllers
builder.Services.AddControllers();

builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));
builder.Services.AddSingleton<IValidatorFactory>(sp =>
    new ServiceProviderValidatorFactory(sp));

// Add Swagger documentation using extension method
builder.Services.AddSwaggerDocumentation();

// Add DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure email service
builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));

builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));


// Configure JWT
builder.Services.AddScoped<IJwtGenerator, GenerateTokenJwt>();

// Register generic repositories and business logic


// Existing code remains unchanged
builder.Services.AddScoped(typeof(IBaseModelData<>), typeof(BaseModelData<>));

builder.Services.AddScoped(typeof(IBaseBusiness<,>), typeof(BaseBusiness<,>));

// Register User-specific services
builder.Services.AddScoped<IUserData, UserData>();
builder.Services.AddScoped<IUserBusiness, UserBusiness>();

// Register Role-specific services
builder.Services.AddScoped<IRolData, RolData>();
builder.Services.AddScoped<IRolBusiness, RolBusiness>();

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IJwtService, JwtService>();

// Register RoleUser-specific services
builder.Services.AddScoped<IRolUserData, RolUserData>();
builder.Services.AddScoped<IRoleUserBusiness, RoleUserBusiness>();

// Register utility helpers
builder.Services.AddScoped<IGenericIHelpers, GenericHelpers>();
builder.Services.AddScoped<IDatetimeHelper, DatetimeHelper>();
builder.Services.AddScoped<IPasswordHelper, PasswordHelper>();
builder.Services.AddScoped<IAuthHeaderHelper, AuthHeaderHelper>();
builder.Services.AddScoped<IRoleHelper, RoleHelper>();
builder.Services.AddScoped<IUserHelper, UserHelper>();
builder.Services.AddScoped<IValidationHelper, ValidationHelper>();
builder.Services.AddHttpContextAccessor();

// Configure JWT Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    var key = Encoding.ASCII.GetBytes(builder.Configuration["JWT:Key"] ?? throw new InvalidOperationException("JWT:Key is not configured"));
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});

var origenesPermitidos = builder.Configuration.GetValue<string>("origenesPermitidos")!.Split(";");
{
    builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(optionsCORS =>
        {
            optionsCORS.WithOrigins(origenesPermitidos).AllowAnyMethod().AllowAnyHeader();
        });
    });

    // Register AutoMapper
    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

    var app = builder.Build();

    // Configure the HTTP request pipeline
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Sistema de Gestión v1");
            c.RoutePrefix = string.Empty; // Para servir Swagger UI en la raíz
        });
    }

    // Use custom exception handling middleware
    app.UseExceptionHandler(appError =>
    {
        appError.Run(async context =>
        {
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync(new
            {
                StatusCode = context.Response.StatusCode,
                Message = "Error interno del servidor."
            }.ToString());
        });
    });

    // Enable CORS
    app.UseCors();

    app.UseHttpsRedirection();

    // Add authentication & authorization
    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();    // Inicializar base de datos y aplicar migraciones para la base de datos principal
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        try
        {
            var dbContext = services.GetRequiredService<ApplicationDbContext>();
            var logger = services.GetRequiredService<ILogger<Program>>();

            // Aplicar migraciones para la base de datos principal
            dbContext.Database.Migrate();
            logger.LogInformation("Base de datos principal verificada y migraciones aplicadas exitosamente.");
        }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "Ocurrió un error durante la migración de la base de datos principal.");
        }
    }

    app.Run();


}