using Entity.Dtos.Base;
using Entity.Model;
using Entity.Model.OthersPerson;

namespace Entity.Dtos.OthersDates.ProviderDTO
{
    public class ProviderDto : GenericDto
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Direction { get; set; }
        public int UserId { get; set; }
    }
}
