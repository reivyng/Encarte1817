using Entity.Model.OthersPerson;

namespace Data.Interfaces.OthersDates
{
    public interface IClientData : IBaseModelData<Client>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Client client);
    }
}
