using Entity.Model.Base;

namespace Entity.Model
{   
    public class Client : GenericModel
    {
        public string PaymentTerms { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        
    }
}