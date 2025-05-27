using Entity.Dtos.Base;

namespace Entity.Dtos.Security.PersonDTO
{
    public class PersonDto : BaseDto
    {
        public string Direccion { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public long PhoneNumber { get; set; }
        public string TypeIdentification { get; set; }
        public long NumberIdentification { get; set; }
    }
}
