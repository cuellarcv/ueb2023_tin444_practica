using SistemaVentas.Application.Interface.Persistence;
using SistemaVentas.Domain.Entities;
using SistemaVentas.Persistence.Context;

namespace SistemaVentas.Persistence.Repository
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly SistemaVentasContext _context;

        public MarcaRepository(SistemaVentasContext context)
        {
            _context = context;
        }

        public void Actualizar(Marca marca)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Marca>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Guardar(Marca marca)
        {
            _context.Marcas.Add(marca);
            _context.SaveChanges();
        }
    }
}
