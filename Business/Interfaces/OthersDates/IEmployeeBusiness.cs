using Entity.Dtos.OthersDates.EmployeeDTO;
using Entity.Model.OthersPerson;

namespace Business.Interfaces.OthersDates
{
    public interface IEmployeeBusiness: IBaseBusiness<Employee, EmployeeDto>
    {
        Task<bool> UpdatePartialAsync(UpdateEmployeeDto dto);
        Task<bool> ActiveAsync(DeleteLogicEmployeeDto dto);
    }
}
