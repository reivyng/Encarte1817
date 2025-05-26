using Entity.Model.Base;

namespace Entity.Model.Security
{
    public class Form : GenericModel
    {
        public string Path { get; set; }
        public ICollection<FormModule> FormModule { get; set; }
        public ICollection<RolFormPermission> RolFormPermission { get; set; }
    }
}
