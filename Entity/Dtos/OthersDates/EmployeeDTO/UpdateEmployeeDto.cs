using Entity.Dtos.Base;

namespace Entity.Dtos.OthersDates.EmployeeDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un rol (operación GET ALL,CREATE,UPDATE(PATCH-PUT))
    /// </summary>
    public class UpdateEmployeeDto : GenericDto
    {
        public string EmployeeCode { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public decimal ContractType { get; set; }
        public decimal WorkSchedule { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime TerminationDate { get; set; }
    }
}
