using Entity.Dtos.Base;

namespace Entity.Dtos.Security.RolFomPermissionDTO
{
    public class RolFormPermissionDto : BaseDto
    {
        public int PermissionId { get; set; }
        public int RolId { get; set; }
        public int FormId { get; set; }
    }
}
