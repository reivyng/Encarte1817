using AutoMapper;
using Entity.Dtos.OthersDates.ProviderDTO;
using Entity.Model.OthersPerson;

namespace Utilities.Mappers.Profiles.OthersDates
{
    public class ProviderProfile : Profile
    {
        public ProviderProfile() 
        {
            CreateMap<Provider, ProviderDto>().ReverseMap();
            CreateMap<Provider, DeleteLogicProviderDto>().ReverseMap();
            CreateMap<Provider, UpdateProviderDto>().ReverseMap();
        }
    }
}
