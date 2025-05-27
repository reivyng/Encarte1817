using Entity.Dtos.Base;

namespace Entity.Dtos.Security.UpdateRolFomPermissionDTO
{
    public class UpdateRolFomPermissionDto : BaseDto
    {
        public int PermissionId { get; set; }
        public int RolId { get; set; }
        public int FormId { get; set; }
    }
}
