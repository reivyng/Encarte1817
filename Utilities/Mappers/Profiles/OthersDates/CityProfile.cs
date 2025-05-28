using AutoMapper;
using Entity.Dtos.OthersDates.CityDTO;
using Entity.Model.OthersPerson;

namespace Utilities.Mappers.Profiles.OthersDates
{
    public class CityProfile : Profile
    {
        public CityProfile() 
        {
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<City, DeleteLogicCityDto>().ReverseMap();
            CreateMap<City, UpdateCityDto>().ReverseMap();
        }
    }
}
