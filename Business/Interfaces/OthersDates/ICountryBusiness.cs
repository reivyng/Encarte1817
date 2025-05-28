using Entity.Dtos.OthersDates.CountryDTO;
using Entity.Model.OthersPerson;

namespace Business.Interfaces.OthersDates
{
    public interface ICountryBusiness:  IBaseBusiness<Country, CountryDto>
    {
        Task<bool> UpdatePartialAsync(UpdateCountryDto dto);
        Task<bool> ActiveAsync(DeleteLogicCountryDto dto);
    }
}
