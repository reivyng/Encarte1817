using Data.Implements.BaseData;
using Data.Interfaces.Security;
using Entity.Context;
using Entity.Model.Security; 

namespace Data.Implements.Security.FormData
{
    public class FormData : BaseModelData<Form>, IFormData
    {
        public FormData(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<bool> ActiveAsync(int id, bool active)
        {
            var form = await _context.Set<Form>().FindAsync(id);
            if (form == null)
                return false;

            form.Status = active;
            _context.Entry(form).Property(f => f.Status).IsModified = true;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdatePartial(Form form)
        {
            var existingForm = await _context.Forms.FindAsync(form.Id);
            if (existingForm == null) return false;
            _context.Forms.Update(existingForm);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
