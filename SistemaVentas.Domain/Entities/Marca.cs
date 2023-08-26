using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SistemaVentas.Domain.Entities
{
    public class Marca
    {
        [Column("idMarca")]
        [Required]
        [Key]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        [StringLength(maximumLength: 100)]
        public string Nombre { get; set; }

        [Column("paisOrigen")]
        [Required]
        [StringLength(maximumLength: 100)]
        public string Origen { get; set; }


        [Column("eliminado")]
        [DefaultValue(0)]
        public bool Eliminado { get; set; }

    }
}
