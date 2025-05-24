using Entity.Dtos.Base;

namespace Entity.Dtos.DeparmentDTO
{
    public class DeparmentDto : GenericDto
    {
        public string DepartmentCode { get; set; }
        public int CountryId { get; set; }
    }
}
