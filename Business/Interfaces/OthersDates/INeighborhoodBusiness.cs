using Entity.Dtos.OthersDates.NeighborhoodDTO;
using Entity.Model.OthersPerson;

namespace Business.Interfaces.OthersDates
{
    public interface INeighborhoodBusiness : IBaseBusiness<Neighborhood, NeighborhoodDto>
    {
        Task<bool> UpdatePartialAsync(UpdateNeighborhoodDto dto);
        Task<bool> ActiveAsync(DeleteLogicNeighborhoodDto dto);
    }
}
