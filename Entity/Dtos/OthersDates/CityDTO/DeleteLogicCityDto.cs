using Entity.Dtos.Base;

namespace Entity.Dtos.OthersDates.CityDTO
{
    /// <summary>
    /// DTO para la creación de un nuevo rol (operación Delete Logico)
    /// </summary>
    public class DeleteLogicCityDto : BaseDto
    {
        public DeleteLogicCityDto()
        {
            Status = false;
        }
    }
}