using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class EstadoFormularioConfig : IEntityTypeConfiguration<EstadoFormulario>
    {
        public void Configure(EntityTypeBuilder<EstadoFormulario> builder)
        {
            builder.ToTable("ESTADOFORMULARIO");

            builder.HasKey(e => e.ESTF_CODIGO);

            builder.Property(e => e.ESTF_NOMBRE)
                .HasMaxLength(100);

            builder.Property(e => e.ESTF_ESTADO)
                .IsRequired()
                .HasDefaultValue(true);

            builder.HasMany(e => e.FORMULARIOSPUBLICADOS)
                .WithOne(fp => fp.ESTADOFORMULARIO)
                .HasForeignKey(fp => fp.ESTF_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.FORMULARIOSBORRADOR)
                .WithOne(fb => fb.ESTADOFORMULARIO)
                .HasForeignKey(fb => fb.ESTF_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.BANCOFORMULARIOS)
                .WithOne(bf => bf.ESTADOFORMULARIO)
                .HasForeignKey(bf => bf.ESTF_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
