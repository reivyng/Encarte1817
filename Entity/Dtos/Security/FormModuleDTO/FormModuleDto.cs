using Entity.Dtos.Base;

namespace Entity.Dtos.Security.FormModuleDTO
{
    public class FormModuleDto : BaseDto
    {
        public int FormId { get; set; }
        public int ModuleId { get; set; }
    }
}