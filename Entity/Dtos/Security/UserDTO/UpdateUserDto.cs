using Entity.Dtos.Base;

namespace Entity.Dtos.Security.UserDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un usuario (operación get all, create, update(patch-put))
    /// </summary>
    public class UpdateUserDto : BaseDto
    {
        public  string Email { get; set; }
        public  string Password { get; set; }
    }
}
