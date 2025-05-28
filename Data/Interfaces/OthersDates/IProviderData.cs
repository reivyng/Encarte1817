using Entity.Model.OthersPerson;

namespace Data.Interfaces.OthersDates
{
    public interface IProviderData : IBaseModelData<Provider>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Provider provider);
    }
}
