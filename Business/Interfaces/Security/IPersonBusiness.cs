using Entity.Dtos.Security.PersonDTO;
using Entity.Model.Security;

namespace Business.Interfaces.Security
{
    public interface IPersonBusiness : IBaseBusiness<Person, PersonDto>
    {
        Task<bool> UpdatePartialAsync(UpdatePersonDto dto);
        Task<bool> ActiveAsync(DeleteLogicPersonDto dto);
    }
}
