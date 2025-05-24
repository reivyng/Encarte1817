using Entity.Model.Base;

namespace Entity.Model
{
    public class Provider : GenericModel
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        // Relación: Un proveedor puede tener muchos clientes (opcional)
        public ICollection<Client> Clientes { get; set; }
    }
}