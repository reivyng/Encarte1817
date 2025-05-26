using Entity.Enums;
using Entity.Model.Base;

namespace Entity.Model.Security
{
    public class Permission : GenericModel
    {
        public PermissionType Type { get; set; }    // Tipo de permiso (CRUD)  
        public ICollection<RolFormPermission> RolFormPermission { get; set; }
    }
}