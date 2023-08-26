using Microsoft.EntityFrameworkCore;
using SistemaVentas.Domain.Entities;
using SistemaVentas.Persistence.Configurations;

namespace SistemaVentas.Persistence.Context
{
    public class SistemaVentasContext : DbContext
    {
        public SistemaVentasContext(DbContextOptions<SistemaVentasContext> options) : base(options) { 

        }

        public virtual DbSet<CategoriaProducto> Categorias { get; set; }

        public virtual DbSet<Producto> Productos { get; set; }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Marca> Marcas { get; set; }

        public virtual DbSet<Venta> Ventas { get; set; }

        public virtual DbSet<DetalleVenta> DetallesVenta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            new MarcaConfig().Configure(modelBuilder.Entity<Marca>());

            new DetalleVentaConfig().Configure(modelBuilder.Entity<DetalleVenta>());
        }



    }
}
