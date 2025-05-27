using Entity.Dtos.Base;

namespace Entity.Dtos.OthersDates.ClientDTO
{
    public class ClientDto : GenericDto
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int ProviderId { get; set; }
        public int UserId { get; set; }
    }
}
