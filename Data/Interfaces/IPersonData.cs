using Entity.Model.Security;

namespace Data.Interfaces
{
    public interface IPersonData : IBaseModelData<Person>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Person person);
    }
}
