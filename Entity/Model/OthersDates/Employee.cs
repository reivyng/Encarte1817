using Entity.Model.Base;
using Entity.Enums;
using Entity.Model.Security;

namespace Entity.Model.OthersPerson
{
    public class Employee : BaseEntity
    {
        public string EmployeeCode { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public decimal WorkSchedule { get; set; }
        public DateTime HiringDate { get; set; } //fecha de contratación
        public DateTime TerminationDate { get; set; }
        public ContractType ContractType { get; set; } //tipo de contrato
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
