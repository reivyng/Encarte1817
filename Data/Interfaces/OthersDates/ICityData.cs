using Entity.Model.OthersPerson;

namespace Data.Interfaces.OthersDates
{
    public interface ICityData : IBaseModelData<City>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(City city);
    }
}
