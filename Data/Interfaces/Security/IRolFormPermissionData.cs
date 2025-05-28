using Entity.Model.Security;

namespace Data.Interfaces.Security
{
    public interface IRolFormPermissionData : IBaseModelData<RolFormPermission>
    {
        Task<bool> UpdatePartial(RolFormPermission rolFormPermission);
    }
}
