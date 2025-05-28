using Entity.Dtos.Security.PermissionDTO;
using Entity.Model.Security;

namespace Business.Interfaces.Security
{
    public interface IPermissionBusiness : IBaseBusiness<Permission, PermissionDto>
    {
        Task<bool> UpdatePartialAsync(UpdatePermissionDto dto);
        Task<bool> ActiveAsync(DeleteLogicPermissionDto dto);
    }
}
