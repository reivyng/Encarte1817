using Entity.Model.Base;

namespace Entity.Model
{
    public class Employee : BaseEntity
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
        public User User { get; set; }
    }
}
