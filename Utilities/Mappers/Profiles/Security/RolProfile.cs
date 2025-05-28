using AutoMapper;
using Entity.Dtos.Security.RolDTO;
using Entity.Model.Security;

namespace Utilities.Mappers.Profiles.Security
{
    public class RolProfile : Profile
    {
        public RolProfile()
        {
            CreateMap<Rol, RolDto>().ReverseMap();
            CreateMap<Rol, DeleteLogiRolDto>().ReverseMap();
            CreateMap<Rol, UpdateRolDto>().ReverseMap();
        }

    }
}