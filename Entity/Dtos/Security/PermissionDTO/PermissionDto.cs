using Entity.Dtos.Base;
using Entity.Enums;

namespace Entity.Dtos.Security.PermissionDTO
{
    public class PermissionDto : GenericDto
    {
        public PermissionType Type { get; set; }
    }
}
