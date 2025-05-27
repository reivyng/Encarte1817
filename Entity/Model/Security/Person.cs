using Entity.Model.Base;

namespace Entity.Model.Security
{
    public class Person : BaseEntity
    {
        public string Direccion {  get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public long PhoneNumber { get; set; }
        public string TypeIdentification { get; set; }
        public long NumberIdentification { get; set; }
        public User User { get; set; }
    }
}
