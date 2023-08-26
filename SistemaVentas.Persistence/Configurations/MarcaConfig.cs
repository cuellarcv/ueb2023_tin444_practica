using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentas.Domain.Entities;

namespace SistemaVentas.Persistence.Configurations
{
    public class MarcaConfig : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("Marca");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(x => x.Origen)
                .IsRequired()
                .HasMaxLength(100);


        }
    }
}
