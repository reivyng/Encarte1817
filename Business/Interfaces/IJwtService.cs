// Business/Interfaces/IJwtService.cs
using System.Security.Claims;
using Entity.Dtos.Security.AuthDTO;
using Entity.Model.Security;

namespace Business.Interfaces
{
    /// <summary>
    /// Servicio para operaciones relacionadas con JWT en la capa de negocio.
    /// </summary>
    public interface IJwtService
    {
        /// <summary>-+
        /// Genera un token JWT para un usuario autenticado.
        /// </summary>
        /// <param name="user">Usuario autenticado</param>
        /// <returns>DTO con el token generado y su fecha de expiraci�n</returns>
        Task<AuthDto> GenerateTokenAsync(User user);

        /// <summary>
        /// Valida un token JWT y extrae sus claims.
        /// </summary>
        /// <param name="token">Token JWT a validar</param>
        /// <returns>ClaimsPrincipal con la informaci�n del token, o null si el token es inv�lido</returns>
        ClaimsPrincipal ValidateToken(string token);

        /// <summary>
        /// Verifica si un token es v�lido sin extraer sus claims.
        /// </summary>
        /// <param name="token">Token JWT a verificar</param>
        /// <returns>True si el token es v�lido; false en caso contrario</returns>
        bool IsTokenValid(string token);
    }
}