using Entity.Model.Security;

namespace Data.Interfaces.Security
{
    public interface IModuleData : IBaseModelData<Module>
    {
        Task<bool> ActiveAsync(int id, bool status);
        Task<bool> UpdatePartial(Module module);
    }
}
