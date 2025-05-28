using AutoMapper;
using Entity.Dtos.OthersDates.NeighborhoodDTO;
using Entity.Model.OthersPerson;

namespace Utilities.Mappers.Profiles.OthersDates
{
    public class NeighborhoodProfile : Profile
    {
        public NeighborhoodProfile() 
        {
            CreateMap<Neighborhood, NeighborhoodDto>().ReverseMap();
            CreateMap<Neighborhood, DeleteLogicNeighborhoodDto>().ReverseMap();
            CreateMap<Neighborhood, UpdateNeighborhoodDto>().ReverseMap();
        }
    }
}
