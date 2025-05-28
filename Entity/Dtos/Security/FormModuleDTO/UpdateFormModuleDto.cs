using Entity.Dtos.Base;

namespace Entity.Dtos.Security.FormModuleDTO
{
    public class UpdateFormModuleDto : BaseDto
    {
        public int FormId { get; set; }
        public int ModuleId { get; set; }
    }
}