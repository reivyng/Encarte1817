using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Country : GenericModel
    {
        public string CountryCode { get; set; }
        public ICollection<Department> Department { get; set; }
    }
}
