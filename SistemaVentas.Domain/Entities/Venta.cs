using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SistemaVentas.Domain.Entities
{
    public class Venta
    {
        [Column("idVenta")]
        [Required]
        [Key]
        public long Id { get; set; }

        [Column("fecha")]
        [Required]
        public DateTime Fecha { get; set; }

        [Column("totalVenta")]
        [Required]
        public decimal Total { get; set; }

        [Column("idCliente")]
        [Required]
        public int idCliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        [Column("eliminado")]
        [DefaultValue(0)]
        public bool Eliminado { get; set; }

        public virtual List<DetalleVenta> DetallesVenta { get; set; }
    }
}
