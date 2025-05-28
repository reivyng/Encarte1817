using AutoMapper;
using Microsoft.Extensions.Logging;
using Utilities.Exceptions;
using ValidationException = Utilities.Exceptions.ValidationException;
using Utilities.Interfaces;
using Entity.Model.OthersPerson;
using Entity.Dtos.OthersDates.DeparmentDTO;
using Data.Interfaces.OthersDates;
using Business.Interfaces.OthersDates;

namespace Business.Implements.OthersDates
{
    /// <summary>
    /// Contiene la lógica de negocio de los métodos específicos para la entidad Deparment.
    /// Extiende BaseBusiness heredando la lógica de negocio de los métodos base.
    /// </summary>
    public class DeparmentBusiness : BaseBusiness<Department, DeparmentDto>, IDepartmentBusiness
    {
        ///<summary>Proporciona acceso a los métodos de la capa de datos de departamentos</summary>
        private readonly IDeparmentData _deparmentData;

        /// <summary>
        /// Constructor de la clase DeparmentBusiness
        /// Inicializa una nueva instancia con las dependencias necesarias para operar con departamentos.
        /// </summary>
        public DeparmentBusiness(IDeparmentData deparmentData, IMapper mapper, ILogger<DeparmentBusiness> logger, IGenericIHelpers helpers)
            : base(deparmentData, mapper, logger, helpers)
        {
            _deparmentData = deparmentData;
        }

        ///<summary>
        /// Actualiza parcialmente un departamento en la base de datos
        /// </summary>
        public async Task<bool> UpdatePartialAsync(UpdateDeparmentDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("ID inválido.");

            var deparment = _mapper.Map<Department>(dto);

            var result = await _deparmentData.UpdatePartial(deparment); // esto ya retorna bool
            return result;
        }

        ///<summary>
        /// Cambia el estado activo/inactivo de un departamento en la base de datos (borrado lógico)
        /// </summary>
        public async Task<bool> ActiveAsync(DeleteLogicDeparmentDto dto)
        {
            if (dto == null || dto.Id <= 0)
                throw new ValidationException("Id", "El ID del departamento es inválido");

            var exists = await _deparmentData.GetByIdAsync(dto.Id)
                ?? throw new EntityNotFoundException("deparment", dto.Id);

            return await _deparmentData.ActiveAsync(dto.Id, dto.Status);
        }
    }
}
