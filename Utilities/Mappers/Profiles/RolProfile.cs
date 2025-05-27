using AutoMapper;
using Entity.Dtos.Security.RolDTO;
using Entity.Model.Security;

namespace Utilities.Mappers.Profiles
{
    public class RolProfile : Profile
    {
        public RolProfile()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Rol, RolDto>().ReverseMap();
        }
    }
}