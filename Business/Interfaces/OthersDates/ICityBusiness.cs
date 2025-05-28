using Entity.Dtos.OthersDates.CityDTO;
using Entity.Model.OthersPerson;

namespace Business.Interfaces.OthersDates
{
    public interface ICityBusiness : IBaseBusiness<City, CityDto>
    {
        Task<bool> UpdatePartialAsync(UpdateCityDto dto);
        Task<bool> ActiveAsync(DeleteLogicCityDto dto);
    }
}
