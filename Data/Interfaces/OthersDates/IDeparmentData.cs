using Entity.Model.OthersPerson;

namespace Data.Interfaces.OthersDates
{
    public interface IDeparmentData : IBaseModelData<Department>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Department department);
    }
}
