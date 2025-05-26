using Entity.Dtos.Base;
using Entity.Model;

namespace Entity.Dtos.ProviderDTO
{
    public class ProviderDto : GenericDto
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int UserId { get; set; }
    }
}
