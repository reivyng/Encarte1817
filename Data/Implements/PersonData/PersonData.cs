using Data.Implements.BaseData;
using Data.Interfaces;
using Entity.Context;
using Entity.Model.Security;

namespace Data.Implements.PersonData
{
    public class PersonData : BaseModelData<Person> , IPersonData
    {
        public PersonData(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<bool> ActiveAsync(int id, bool active)
        {
            var user = await _context.Set<Person>().FindAsync(id);
            if (user == null)
                return false;

            user.Status = active;
            _context.Entry(user).Property(u => u.Status).IsModified = true;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
