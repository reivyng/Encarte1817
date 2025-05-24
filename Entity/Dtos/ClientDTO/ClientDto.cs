using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.ClientDTO
{
    public class ClientDto : GenericDto
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public int CityId { get; set; }
    }
}
