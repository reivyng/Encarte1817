using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.FormModuleDTO
{
    public class FormModuleDto : BaseDto
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public int ModuleId { get; set; }
    }
}
