using Data.Implements.BaseData;
using Data.Interfaces.OthersDates;
using Entity.Context;
using Entity.Model.OthersPerson;

namespace Data.Implements.OtherDates.CityData
{
    public class CityData : BaseModelData<City>, ICityData
    {
        public CityData(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<bool> ActiveAsync(int id, bool active)
        {
            var city = await _context.Set<City>().FindAsync(id);
            if (city == null)
                return false;

            city.Status = active;
            _context.Entry(city).Property(c => c.Status).IsModified = true;

            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdatePartial(City city)
        {
            var existingCity = await _context.Citys.FindAsync(city.Id);
            if (existingCity == null) return false;
            _context.Citys.Update(existingCity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
