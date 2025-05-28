using Entity.Model.Security;

namespace Data.Interfaces.Security
{
    public interface IPermissionData : IBaseModelData<Permission>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Permission permission);
    }
}
