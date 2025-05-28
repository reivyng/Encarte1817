using Entity.Dtos.Security.FormDTO;
using Entity.Model.Security;

namespace Business.Interfaces.Security
{
    public interface IFormBusiness : IBaseBusiness<Form, FormDto>
    {
        Task<bool> UpdatePartialAsync(UpdateFormDto dto);
        Task<bool> ActiveAsync(DeleteLogicFormDto dto);
    }
}
