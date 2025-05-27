using Entity.Dtos.Base;

namespace Entity.Dtos.OthersDates.ClientDTO
{
    /// <summary>
    /// DTO para la creación de un nuevo rol (operación Delete Logico)
    /// </summary>
    public class DeleteLogicClientDto : BaseDto
    {
        public DeleteLogicClientDto()
        {
            Status = false;
        }
    }
}