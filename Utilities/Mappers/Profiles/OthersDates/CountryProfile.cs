using AutoMapper;
using Entity.Dtos.OthersDates.CountryDTO;
using Entity.Model.OthersPerson;

namespace Utilities.Mappers.Profiles.OthersDates
{
    public class CountryProfile : Profile
    {
        public CountryProfile() 
        {
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, DeleteLogicCountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();
        }
    }
}
