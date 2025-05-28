using Data.Implements.BaseData;
using Data.Interfaces.Security;
using Entity.Context;
using Entity.Model.Security;

namespace Data.Implements.Security.ModuleData
{
    public class ModuleData : BaseModelData<Module>, IModuleData
    {
        public ModuleData(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<bool> ActiveAsync(int id, bool active)
        {
            var module = await _context.Set<Module>().FindAsync(id);
            if (module == null)
                return false;

            module.Status = active;
            _context.Entry(module).Property(m => m.Status).IsModified = true;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdatePartial(Module module)
        {
            var existingModule = await _context.Modules.FindAsync(module.Id);
            if (existingModule == null) return false;
            _context.Modules.Update(existingModule);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
