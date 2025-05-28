using Entity.Model.Security;

namespace Data.Interfaces.Security
{
    public interface IRolData : IBaseModelData<Rol>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Rol rol);
    }
}
