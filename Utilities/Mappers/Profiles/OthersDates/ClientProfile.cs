using AutoMapper;
using Entity.Dtos.OthersDates.ClientDTO;
using Entity.Model.OthersPerson;

namespace Utilities.Mappers.Profiles.OthersDates
{
    public class ClientProfile : Profile
    {
        public ClientProfile() 
        {
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Client, DeleteLogicClientDto>().ReverseMap();
            CreateMap<Client, UpdateClientDto>().ReverseMap();
        }
    }
}
