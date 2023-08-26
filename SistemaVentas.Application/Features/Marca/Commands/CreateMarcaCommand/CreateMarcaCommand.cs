using SistemaVentas.Application.Interface.Persistence;
using SistemaVentas.Application.Wrappers;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Application.Features.Marca.Commands.CreateMarcaCommand
{
    public class CreateMarcaCommand
    {
        private readonly IMarcaRepository _marcaRepository;

        public CreateMarcaCommand(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        public Response<SistemaVentas.Domain.Entities.Marca> Guardar(CreateMarcaCommandParameters parametros)
        {
            SistemaVentas.Domain.Entities.Marca objMarca = new SistemaVentas.Domain.Entities.Marca();

            objMarca.Nombre = parametros.Nombre;
            objMarca.Origen = parametros.Origen;

            _marcaRepository.Guardar(objMarca);

            return new Response<SistemaVentas.Domain.Entities.Marca>(objMarca);
        }


    }
}
