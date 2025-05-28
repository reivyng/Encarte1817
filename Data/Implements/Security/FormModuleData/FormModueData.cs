using Data.Implements.BaseData;
using Data.Interfaces.Security;
using Entity.Context;
using Entity.Model.Security;

namespace Data.Implements.Security.FormModuleData
{
    public class FormModuleData : BaseModelData<FormModule>, IFormModuleData
    {
        public FormModuleData(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<bool> UpdatePartial(FormModule formModule)
        {
            var existingFormModule = await _context.ModulesModule.FindAsync(formModule.Id);
            if (existingFormModule == null) return false;
            // Actualiza solo los campos que no sean nulos o tengan valor válido
            if (formModule.FormId > 0) existingFormModule.FormId = formModule.FormId;
            if (formModule.ModuleId > 0) existingFormModule.ModuleId = formModule.ModuleId;
            _context.ModulesModule.Update(existingFormModule);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
