using Entity.Dtos.Base;

namespace Entity.Dtos.OthersDates.DeparmentDTO
{
    /// <summary>
    /// DTO para la creación de un nuevo rol (operación Delete Logico)
    /// </summary>
    public class DeleteLogicDeparmentDto : BaseDto
    {
        public DeleteLogicDeparmentDto()
        {
            Status = false;
        }
    }
}