using Entity.Dtos.Security.ModuleDTO;
using Entity.Model.Security;

namespace Business.Interfaces.Security
{
    public interface IModuleBusiness :IBaseBusiness<Module, ModuleDto>
    {
        Task<bool> UpdatePartialAsync(UpdateModuleDto dto);
        Task<bool> ActiveAsync(DeleteLogicModuleDto dto);
    }
}
