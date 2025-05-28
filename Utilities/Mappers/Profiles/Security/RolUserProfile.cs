using AutoMapper;
using Entity.Dtos.RolUserDTO;
using Entity.Model.Security;

namespace Utilities.Mappers.Profiles.Security
{
    public class RolUserProfile : Profile
    {
        public RolUserProfile() 
        {
            CreateMap<RolUser, RolUserDto>().ReverseMap();
        } 
    }
}
