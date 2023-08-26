
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Application.Interface.Persistence
{
    public interface IMarcaRepository
    {
        void Guardar(Marca marca);

        void Actualizar(Marca marca);

        void Eliminar(int id);

        Task<List<Marca>> GetAll();
    }
}
