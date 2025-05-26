using Entity.Model.Base;

namespace Entity.Model.Security
{
    public class Module : GenericModel
    {
        public ICollection<FormModule> FormModule { get; set; }
    }
}