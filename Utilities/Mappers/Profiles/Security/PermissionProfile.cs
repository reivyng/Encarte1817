using AutoMapper;
using Entity.Dtos.Security.PermissionDTO;
using Entity.Model.Security;

namespace Utilities.Mappers.Profiles.Security
{
    public class PermissionProfile : Profile
    {
        public PermissionProfile() 
        {
            CreateMap<Permission, PermissionDto>().ReverseMap();
            CreateMap<Permission, DeleteLogicPermissionDto>().ReverseMap();
            CreateMap<Permission, UpdatePermissionDto>().ReverseMap();
        }
    }
}
