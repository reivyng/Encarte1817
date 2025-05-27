using Entity.Dtos.Base;

namespace Entity.Dtos.RolUserDTO
{
    public class RolUserDto : BaseDto
    {
        public int RolId { get; set; }
        public int UserId { get; set; }
    }
}
