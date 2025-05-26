
using Microsoft.AspNetCore.Mvc;
using Entity.Dtos.RolUserDTO;
using Web.Controllers.Interface;
using Entity.Model.Security;

namespace Web.Controllers.Interface
{
    public interface IRoleUserController : IGenericController<RolUserDto, RolUser>
    {
        Task<IActionResult> UpdatePartialRoleUser(int id,int roluser,UpdateRolUserDto dto);
    }
}