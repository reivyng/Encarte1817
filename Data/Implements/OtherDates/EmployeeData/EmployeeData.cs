using Data.Implements.BaseData;
using Data.Interfaces.OthersDates;
using Entity.Context;
using Entity.Model.OthersPerson; 

namespace Data.Implements.OtherDates.EmployeeData
{
    public class EmployeeData : BaseModelData<Employee>, IEmployeeData
    {
        public EmployeeData(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<bool> ActiveAsync(int id, bool active)
        {
            var employee = await _context.Set<Employee>().FindAsync(id);
            if (employee == null)
                return false;

            employee.Status = active;
            _context.Entry(employee).Property(e => e.Status).IsModified = true;

            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdatePartial(Employee employee)
        {
            var existingEmployee = await _context.Employees.FindAsync(employee.Id);
            if (existingEmployee == null) return false;
            _context.Employees.Update(existingEmployee);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
