using Entity.Dtos.Base;

namespace Entity.Dtos.OthersDates.ClientDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un rol (operación GET ALL,CREATE,UPDATE(PATCH-PUT))
    /// </summary>
    public class UpdateClientDto : GenericDto
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int ProviderId { get; set; }
    }
}
