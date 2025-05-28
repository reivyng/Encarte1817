using Entity.Model.Security;

namespace Data.Interfaces.Security
{
    public interface IFormModuleData : IBaseModelData<FormModule>
    {
        Task<bool> UpdatePartial(FormModule formModule);
    }
}
