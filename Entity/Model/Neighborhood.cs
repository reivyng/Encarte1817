using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Neighborhood : GenericModel
    {
        public string CodePostal {  get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
