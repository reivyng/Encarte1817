using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.neighborhoodDTO
{
    public class NeighborhoodDto : GenericDto
    {
        public string CodePostal { get; set; }
        public int CityId { get; set; }
    }
}
