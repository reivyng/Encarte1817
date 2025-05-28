using AutoMapper;
using Microsoft.Extensions.Logging;
using Utilities.Exceptions;
using ValidationException = Utilities.Exceptions.ValidationException;
using Utilities.Interfaces;
using Entity.Model.OthersPerson;
using Entity.Dtos.OthersDates.ProviderDTO;
using Data.Interfaces.OthersDates;
using Business.Interfaces.OthersDates;

namespace Business.Implements.OthersDates
{
    /// <summary>
    /// Contiene la lógica de negocio de los métodos específicos para la entidad Provider.
    /// Extiende BaseBusiness heredando la lógica de negocio de los métodos base.
    /// </summary>
    public class ProviderBusiness : BaseBusiness<Provider, ProviderDto>, IProviderBusiness
    {
        ///<summary>Proporciona acceso a los métodos de la capa de datos de proveedores</summary>
        private readonly IProviderData _providerData;

        /// <summary>
        /// Constructor de la clase ProviderBusiness
        /// Inicializa una nueva instancia con las dependencias necesarias para operar con proveedores.
        /// </summary>
        public ProviderBusiness(IProviderData providerData, IMapper mapper, ILogger<ProviderBusiness> logger, IGenericIHelpers helpers)
            : base(providerData, mapper, logger, helpers)
        {
            _providerData = providerData;
        }

        ///<summary>
        /// Actualiza parcialmente un proveedor en la base de datos
        /// </summary>
        public async Task<bool> UpdatePartialAsync(UpdateProviderDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("ID inválido.");

            var provider = _mapper.Map<Provider>(dto);

            var result = await _providerData.UpdatePartial(provider); // esto ya retorna bool
            return result;
        }

        ///<summary>
        /// Cambia el estado activo/inactivo de un proveedor en la base de datos (borrado lógico)
        /// </summary>
        public async Task<bool> ActiveAsync(DeleteLogicProviderDto dto)
        {
            if (dto == null || dto.Id <= 0)
                throw new ValidationException("Id", "El ID del proveedor es inválido");

            var exists = await _providerData.GetByIdAsync(dto.Id)
                ?? throw new EntityNotFoundException("provider", dto.Id);

            return await _providerData.ActiveAsync(dto.Id, dto.Status);
        }
    }
}
