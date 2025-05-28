using Entity.Dtos.Security.RolFomPermissionDTO;
using Entity.Model.Security;

namespace Business.Interfaces.Security
{
    public interface IRolFormPermissionBusiness : IBaseBusiness<RolFormPermission, RolFormPermissionDto >
    {
        Task<bool> UpdatePartialAsync(UpdateRolFomPermissionDto dto);
    }
}
