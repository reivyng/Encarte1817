using Entity.Dtos.Security.FormModuleDTO;
using Entity.Model.Security;

namespace Business.Interfaces.Security
{
    public interface IFormModuleBusiness : IBaseBusiness<FormModule, FormModuleDto >
    {
        Task<bool> UpdatePartialAsync(UpdateFormModuleDto dto);
    }
}
