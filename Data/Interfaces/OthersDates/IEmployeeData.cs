using Entity.Model.OthersPerson;

namespace Data.Interfaces.OthersDates
{
    public interface IEmployeeData : IBaseModelData<Employee>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Employee employee);
    }
}
