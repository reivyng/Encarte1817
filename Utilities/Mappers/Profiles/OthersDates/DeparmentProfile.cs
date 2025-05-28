using AutoMapper;
using Entity.Dtos.OthersDates.DeparmentDTO;
using Entity.Model.OthersPerson;

namespace Utilities.Mappers.Profiles.OthersDates
{
    public class DeparmentProfile : Profile
    {
        public DeparmentProfile()
        {
            CreateMap<Department, DeparmentDto>().ReverseMap();
            CreateMap<Department, DeleteLogicDeparmentDto>().ReverseMap();
            CreateMap<Department, UpdateDeparmentDto>().ReverseMap();
        }
    }
}
