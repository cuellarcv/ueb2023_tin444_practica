
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SistemaVentas.Domain.Entities
{
    public class Producto
    {
        [Column("idproducto")]
        [Required]
        [Key]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(maximumLength: 255)]
        public string Nombre { get; set; }

        [Column("caracteristicas")]
        [Required]
        [StringLength(maximumLength: 255)]
        public string Caracteristicas { get; set; }

        [Column("modelo")]
        [Required]
        [StringLength(maximumLength: 255)]
        public string Modelo { get; set; }

        [Column("peso")]
        [Required]
        [DefaultValue(0)]
        public decimal Peso { get; set; }

        [Column("dimensiones")]
        [StringLength(maximumLength: 255)]
        public string Dimensiones { get; set; }

        [Column("precioReferencial")]
        [Required]
        public decimal PrecioReferencial { get; set; }

        [Column("idMarca")]
        [Required]
        public int IdMarca { get; set; }

        public virtual Marca Marca { get; set; }

        [Column("idCategoriaproducto")]
        [Required]
        public int IdCategoriaProducto { get; set; }

        public virtual CategoriaProducto Categoriaproducto { get; set; }

        [Column("eliminado")]
        [DefaultValue(0)]
        public bool Eliminado { get; set; }

    }
}
