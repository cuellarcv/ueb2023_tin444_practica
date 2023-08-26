using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaVentas.Domain.Entities
{
    public class DetalleVenta
    {
        [Column("idVenta")]
        [Required]
        public long idVenta { get; set; }

        public virtual Venta Venta { get; set; }


        [Column("idProducto")]
        [Required]
        public int idProducto { get; set; }

        public virtual Producto Producto { get; set; }

        [Column("cantidad")]
        [Required]
        public int Cantidad { get; set; }

        [Column("precioUnitario")]
        [Required]
        public decimal PrecioUnitario { get; set; }
    }
}
