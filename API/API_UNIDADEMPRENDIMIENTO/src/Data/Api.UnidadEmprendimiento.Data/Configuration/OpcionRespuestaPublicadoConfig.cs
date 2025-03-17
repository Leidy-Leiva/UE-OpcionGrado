using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class OpcionRespuestaPublicadoConfig : IEntityTypeConfiguration<OpcRespuestaPublicado>
    {
        public void Configure(EntityTypeBuilder<OpcRespuestaPublicado> builder)
        {
            builder.ToTable("OPCIONRESPUESTAPUBLICADO");

            builder.HasKey (bore=> bore.OPRP_CODIGO);

            builder.Property(bore => bore.OPRP_VALOR)
                .HasMaxLength(500);

            builder.Property(bore => bore.OPRP_FECHARESPUESTA)
                .IsRequired();

            builder.Property(bore => bore.OPRP_ESTADO)
                .IsRequired(false)
                .HasDefaultValue(true)
                .ValueGeneratedOnAdd();

            builder.Property(bore => bore.OPRP_ORDEN)
                .IsRequired(); // Opcional

   
        }
    }
}