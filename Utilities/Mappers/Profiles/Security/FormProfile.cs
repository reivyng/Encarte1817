using AutoMapper;
using Entity.Dtos.Security.FormDTO;
using Entity.Model.Security;

namespace Utilities.Mappers.Profiles.Security
{
    public class FormProfile : Profile
    {
        public FormProfile() 
        {
            CreateMap<Form, FormDto>().ReverseMap();
            CreateMap<Form, DeleteLogicFormDto>().ReverseMap();
            CreateMap<Form, UpdateFormDto>().ReverseMap();
        }
    }
}
