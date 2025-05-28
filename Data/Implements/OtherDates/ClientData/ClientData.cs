using Data.Implements.BaseData;
using Data.Interfaces.OthersDates;
using Entity.Context;
using Entity.Model.OthersPerson;

namespace Data.Implements.OtherDates.ClientData
{
    public class ClientData : BaseModelData<Client>, IClientData
    {
        public ClientData(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<bool> ActiveAsync(int id, bool active)
        {
            var client = await _context.Set<Client>().FindAsync(id);
            if (client == null) 
                return false;

            client.Status = active;
            _context.Entry(client).Property(c => c.Status).IsModified = true;

            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdatePartial(Client client)
        {
            var existingClient = await _context.Clients.FindAsync(client.Id);
            if (existingClient == null) return false;
            _context.Clients.Update(existingClient);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
