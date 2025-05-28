using Data.Implements.BaseData;
using Data.Interfaces.Security;
using Entity.Context;
using Entity.Model.Security; 

namespace Data.Implements.Security.PermissionData
{
    public class PermissionData : BaseModelData<Permission>, IPermissionData
    {
        public PermissionData(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<bool> ActiveAsync(int id, bool active)
        {
            var permission = await _context.Set<Permission>().FindAsync(id);
            if (permission == null)
                return false;

            permission.Status = active;
            _context.Entry(permission).Property(p => p.Status).IsModified = true;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdatePartial(Permission permission)
        {
            var existingPermission = await _context.Permissions.FindAsync(permission.Id);
            if (existingPermission == null) return false;
            _context.Permissions.Update(existingPermission);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
