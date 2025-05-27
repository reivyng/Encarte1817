using Entity.Dtos.Base;

namespace Entity.Dtos.OthersDates.CountryDTO
{
    /// <summary>
    /// DTO para la creación de un nuevo rol (operación Delete Logico)
    /// </summary>
    public class DeleteLogicCountryDto : BaseDto
    {
        public DeleteLogicCountryDto()
        {
            Status = false;
        }
    }
}