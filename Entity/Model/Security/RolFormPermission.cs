using Entity.Model.Base;

namespace Entity.Model.Security
{
    public class RolFormPermission : BaseEntity
    {
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
        public int FormId { get; set; }
        public Form Form { get; set; }
    }
}
