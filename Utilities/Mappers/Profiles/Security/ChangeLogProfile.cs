using AutoMapper;
using Entity.Dtos.Security.ChangeLogDTO;
using Entity.Model.Security;

namespace Utilities.Mappers.Profiles.Security
{
    public class ChangeLogProfile : Profile
    {
        public ChangeLogProfile() 
        {
            CreateMap<ChangeLog, ChangeLogDto>().ReverseMap();
        }
    }
}
