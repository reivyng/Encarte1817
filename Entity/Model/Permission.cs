using Entity.Model.Base;

namespace Entity.Model
{
    public class Permission : GenericModel
    {
        public ICollection<RolFormPermission> RolFormPermission { get; set; }
    }
}