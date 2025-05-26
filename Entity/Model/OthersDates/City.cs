using Entity.Model.Base;

namespace Entity.Model.OthersPerson
{
    public class City : GenericModel
    {
        public int DeparmentId { get; set; }
        public Department Department { get; set; }

        // Relación: Una ciudad puede tener muchos clientes
        public ICollection<Client> Clientes { get; set; }
        public ICollection<Neighborhood> Neighborhoods { get; set; }
    }
}
