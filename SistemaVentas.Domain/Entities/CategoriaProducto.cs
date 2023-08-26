using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentas.Domain.Entities
{
    public class CategoriaProducto
    {
        [Column("idCategoriaProducto")]
        [Required]
        [Key]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(maximumLength: 100)]
        public string Nombre { get; set; }

        [Column("descripcion")]
        [StringLength(maximumLength: 255)]
        public string Descripcion { get; set; }

        [Column("eliminado")]
        [DefaultValue(0)]
        public bool Eliminado { get; set; }
    }
}
