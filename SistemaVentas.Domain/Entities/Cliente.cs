using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SistemaVentas.Domain.Entities
{
    public class Cliente
    {
        [Column("idCliente")]
        [Required]
        [Key]
        public int Id { get; set; }

        [Column("nombreCompleto")]
        [Required]
        [StringLength(maximumLength: 255)]
        public string NombreCompleto { get; set; }

        [Column("celular")]
        [Required]
        [StringLength(maximumLength: 100)]
        public string Celular { get; set; }

        [Column("email")]
        [Required]
        [StringLength(maximumLength: 255)]
        public string Email { get; set; }

        [Column("direccion")]
        [StringLength(maximumLength: 255)]
        public string Direccion { get; set; }

        [Column("fechaNacimiento")]
        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Column("eliminado")]
        [DefaultValue(0)]
        public bool Eliminado { get; set; }


    }
}
