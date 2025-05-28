using AutoMapper;
using Entity.Dtos.Security.PersonDTO;
using Entity.Model.Security;

namespace Utilities.Mappers.Profiles.Security
{
    public class PersonProfile : Profile
    {
        public PersonProfile() 
        {
            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<Person, DeleteLogicPersonDto>().ReverseMap();
            CreateMap<Person, UpdatePersonDto>().ReverseMap();
        }
    }
}