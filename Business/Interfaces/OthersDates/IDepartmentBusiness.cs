using Entity.Dtos.OthersDates.DeparmentDTO;
using Entity.Model.OthersPerson;

namespace Business.Interfaces.OthersDates
{
    public interface IDepartmentBusiness : IBaseBusiness<Department, DeparmentDto>
    {
        Task<bool> UpdatePartialAsync(UpdateDeparmentDto dto);
        Task<bool> ActiveAsync(DeleteLogicDeparmentDto dto);
    }
}
