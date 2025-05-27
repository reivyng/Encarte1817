using Microsoft.AspNetCore.Mvc;
using Entity.Model.Security;
using Entity.Dtos.Security.RolDTO;

namespace Web.Controllers.Interface
{
    public interface IRoleController : IGenericController<RolDto, Rol>
    {
        Task<IActionResult> UpdatePartialRole( int id, int roleId, UpdateRolDto dto);
        Task<IActionResult> DeleteLogicRole(int id);
    }
}