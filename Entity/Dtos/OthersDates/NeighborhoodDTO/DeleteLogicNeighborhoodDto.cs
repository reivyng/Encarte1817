using Entity.Dtos.Base;

namespace Entity.Dtos.OthersDates.NeighborhoodDTO
{
    /// <summary>
    /// DTO para la creación de un nuevo rol (operación Delete Logico)
    /// </summary>
    public class DeleteLogicNeighborhoodDto : BaseDto
    {
        public DeleteLogicNeighborhoodDto()
        {
            Status = false;
        }
    }
}