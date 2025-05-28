using AutoMapper;
using Microsoft.Extensions.Logging;
using Utilities.Exceptions;
using ValidationException = Utilities.Exceptions.ValidationException;
using Utilities.Interfaces;
using Entity.Model.Security;
using Entity.Dtos.Security.ModuleDTO;
using Data.Interfaces.Security;
using Business.Interfaces.Security;

namespace Business.Implements.Security
{
    /// <summary>
    /// Contiene la lógica de negocio de los métodos específicos para la entidad Module.
    /// Extiende BaseBusiness heredando la lógica de negocio de los métodos base.
    /// </summary>
    public class ModuleBusiness : BaseBusiness<Module, ModuleDto>, IModuleBusiness
    {
        ///<summary>Proporciona acceso a los métodos de la capa de datos de módulos</summary>
        private readonly IModuleData _moduleData;

        /// <summary>
        /// Constructor de la clase ModuleBusiness
        /// Inicializa una nueva instancia con las dependencias necesarias para operar con módulos.
        /// </summary>
        public ModuleBusiness(IModuleData moduleData, IMapper mapper, ILogger<ModuleBusiness> logger, IGenericIHelpers helpers)
            : base(moduleData, mapper, logger, helpers)
        {
            _moduleData = moduleData;
        }

        ///<summary>
        /// Actualiza parcialmente un módulo en la base de datos
        /// </summary>
        public async Task<bool> UpdatePartialAsync(UpdateModuleDto dto)
        {
            if (dto.Id <= 0)
                throw new ArgumentException("ID inválido.");

            var module = _mapper.Map<Module>(dto);

            var result = await _moduleData.UpdatePartial(module); // esto ya retorna bool
            return result;
        }

        ///<summary>
        /// Cambia el estado activo/inactivo de un módulo en la base de datos (borrado lógico)
        /// </summary>
        public async Task<bool> ActiveAsync(DeleteLogicModuleDto dto)
        {
            if (dto == null || dto.Id <= 0)
                throw new ValidationException("Id", "El ID del módulo es inválido");

            var exists = await _moduleData.GetByIdAsync(dto.Id)
                ?? throw new EntityNotFoundException("module", dto.Id);

            return await _moduleData.ActiveAsync(dto.Id, dto.Status);
        }
    }
}
