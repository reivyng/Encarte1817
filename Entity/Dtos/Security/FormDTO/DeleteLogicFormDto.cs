using Entity.Dtos.Base;

namespace Entity.Dtos.Security.FormDTO
{
    /// <summary>
    /// DTO para la creación de un nuevo rol (operación Delete Logico)
    /// </summary>
    public class DeleteLogicFormDto : BaseDto
    {
        public DeleteLogicFormDto()
        {
            Status = false;
        }
    }
}