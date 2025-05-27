using Entity.Model.Security;

namespace Data.Interfaces
{
    public interface IRolData : IBaseModelData<Rol>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Rol rol);
    }
}
