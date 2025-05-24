using Entity.Model.Base;

namespace Entity.Model
{
    public class Module : GenericModel
    {
        public ICollection<FormModule> FormModule { get; set; }
    }
}