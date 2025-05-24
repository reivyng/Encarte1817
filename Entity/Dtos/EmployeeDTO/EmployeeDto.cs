using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.EmployeeDTO
{
    public class EmployeeDto : GenericDto
    {
        public string EmployeeCode { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public decimal ContractType { get; set; }
        public decimal WorkSchedule { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public int UserId { get; set; }
    }
}
