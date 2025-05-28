using Data.Implements.BaseData;
using Data.Interfaces.OthersDates;
using Entity.Context;
using Entity.Model.OthersPerson;

namespace Data.Implements.OtherDates.DepartmentData
{
    public class DeparmentData : BaseModelData<Department>, IDeparmentData
    {
        public DeparmentData(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<bool> ActiveAsync(int id, bool active)
        {
            var department = await _context.Set<Department>().FindAsync(id);
            if (department == null)
                return false;

            department.Status = active;
            _context.Entry(department).Property(d => d.Status).IsModified = true;

            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdatePartial(Department department)
        {
            var existingDepartment = await _context.Departments.FindAsync(department.Id);
            if (existingDepartment == null) return false;
            _context.Departments.Update(existingDepartment);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
