using Entity.Model.Base;
using Entity.Model.Security;

namespace Entity.Model.OthersPerson
{   
    public class Client : GenericModel
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}