using Entity.Dtos.Base;

namespace Entity.Dtos.OthersDates.EmployeeDTO
{
    /// <summary>
    /// DTO para la creación de un nuevo rol (operación Delete Logico)
    /// </summary>
    public class DeleteLogicEmployeeDto : BaseDto
    {
        public DeleteLogicEmployeeDto()
        {
            Status = false;
        }
    }
}