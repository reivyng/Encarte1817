using AutoMapper;
using Entity.Dtos.Security.RolFomPermissionDTO;
using Entity.Model.Security;

namespace Utilities.Mappers.Profiles.Security
{
    public class RolFormPermissionProfile : Profile
    {
        public RolFormPermissionProfile() 
        {
            CreateMap<RolFormPermission, RolFormPermissionDto>().ReverseMap();
            CreateMap<RolFormPermission, DeleteLogiRolFomPermissionDto>().ReverseMap();
            CreateMap<RolFormPermission, UpdateRolFomPermissionDto>().ReverseMap();
        }
    }
}
