using Entity.Model.Base;
using Entity.Model.Security;

namespace Entity.Model.OthersPerson
{
    public class Provider : GenericModel
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Direction { get; set; }

        // Relación: Un proveedor puede tener muchos clientes 
        public ICollection<Client> Clients { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}