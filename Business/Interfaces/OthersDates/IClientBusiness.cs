using Entity.Dtos.OthersDates.ClientDTO;
using Entity.Model.OthersPerson;

namespace Business.Interfaces.OthersDates
{
    public interface IClientBusiness: IBaseBusiness<Client, ClientDto>
    {
        Task<bool> UpdatePartialAsync(UpdateClientDto dto);
        Task<bool> ActiveAsync(DeleteLogicClientDto dto);
    }
}
