using Entity.Dtos.OthersDates.ProviderDTO;
using Entity.Model.OthersPerson;

namespace Business.Interfaces.OthersDates
{
    internal interface IProviderBusiness : IBaseBusiness<Provider, ProviderDto>
    {
        Task<bool> UpdatePartialAsync(UpdateProviderDto dto);
        Task<bool> ActiveAsync(DeleteLogicProviderDto dto);
    }
}
