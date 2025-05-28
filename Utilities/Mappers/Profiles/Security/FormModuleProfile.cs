using AutoMapper;
using Entity.Dtos.Security.FormModuleDTO;
using Entity.Model.Security;

namespace Utilities.Mappers.Profiles.Security
{
    public class FormModuleProfile : Profile
    {
        public FormModuleProfile() 
        {
            CreateMap<FormModule, FormModuleDto>().ReverseMap();
            CreateMap<FormModule, DeleteLogicFormModuleDto>().ReverseMap();
            CreateMap<FormModule, UpdateFormModuleDto>().ReverseMap();
        }
    }
}
