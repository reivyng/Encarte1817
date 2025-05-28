using Data.Implements.BaseData;
using Data.Interfaces.OthersDates;
using Entity.Context;
using Entity.Model.OthersPerson;

namespace Data.Implements.OtherDates.CountryData
{
    public class CountryData : BaseModelData<Country>, ICountryData
    {
        public CountryData(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<bool> ActiveAsync(int id, bool active)
        {
            var country = await _context.Set<Country>().FindAsync(id);
            if (country == null)
                return false;

            country.Status = active;
            _context.Entry(country).Property(c => c.Status).IsModified = true;

            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdatePartial(Country country)
        {
            var existingCountry = await _context.Countrys.FindAsync(country.Id);
            if (existingCountry == null) return false;
            _context.Countrys.Update(existingCountry);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
