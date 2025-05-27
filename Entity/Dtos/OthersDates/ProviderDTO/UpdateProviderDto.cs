using Entity.Dtos.Base;

namespace Entity.Dtos.OthersDates.ProviderDTO
{
    public class UpdateProviderDto : GenericDto
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Direction { get; set; }
    }
}