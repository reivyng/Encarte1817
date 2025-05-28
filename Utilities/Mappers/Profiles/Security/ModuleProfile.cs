using AutoMapper;
using Entity.Dtos.Security.ModuleDTO;
using Entity.Model.Security;

namespace Utilities.Mappers.Profiles.Security
{
    public class ModuleProfile : Profile
    {
        public ModuleProfile() 
        {
            CreateMap<Module, ModuleDto>().ReverseMap();
            CreateMap<Module, DeleteLogicModuleDto>().ReverseMap();
            CreateMap<Module, UpdateModuleDto>().ReverseMap();
        }
    }
}