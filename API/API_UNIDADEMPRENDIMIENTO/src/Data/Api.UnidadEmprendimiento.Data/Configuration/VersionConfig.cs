using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.UnidadEmprendimiento.Data.Configuration{

    public class VersionConfig : IEntityTypeConfiguration<VersionP>
    {
        public void Configure(EntityTypeBuilder<VersionP> builder)
        {
            builder.ToTable("VERSION");

            builder.HasKey(v => v.VERS_CODIGO);

            builder.Property(v => v.VERS_FECHAMOFICIACION)
                .IsRequired();

            builder.Property(v => v.VERS_NUMERO)
                .IsRequired();

            builder.Property(v => v.VERS_COMENTARIO)
                .HasMaxLength(500);

            builder.Property(v => v.VERS_ESTADO)
                .IsRequired()
                .HasDefaultValue(true)
                .ValueGeneratedOnAdd();

            builder.HasMany(v => v.VERSIONESFP)
                .WithOne(vfp => vfp.VERSION)
                .HasForeignKey(vfp => vfp.VERS_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }

}