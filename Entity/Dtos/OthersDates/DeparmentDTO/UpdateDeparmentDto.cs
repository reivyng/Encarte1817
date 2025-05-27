using Entity.Dtos.Base;

namespace Entity.Dtos.OthersDates.DeparmentDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un rol (operación GET ALL,CREATE,UPDATE(PATCH-PUT))
    /// </summary>
    public class UpdateDeparmentDto : GenericDto
    {
        public string DepartmentCode { get; set; }
        public int CountryId { get; set; }
    }
}
