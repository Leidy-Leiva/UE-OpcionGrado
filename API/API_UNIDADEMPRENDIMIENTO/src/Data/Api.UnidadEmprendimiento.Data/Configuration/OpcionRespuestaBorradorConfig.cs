using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class OpcionRespuestaBorradorConfig : IEntityTypeConfiguration<OpcRespuestaBorrador>
    {
        public void Configure(EntityTypeBuilder<OpcRespuestaBorrador> builder)
        {
            builder.ToTable("OPCIONRESPUESTABOIRRADOR");

            builder.HasKey (bore=> bore.OPRB_CODIGO);

            builder.Property(bore => bore.OPRB_VALOR)
                .HasMaxLength(500);

            builder.Property(bore => bore.OPRB_FECHARESPUESTA)
                .IsRequired();

            builder.Property(bore => bore.OPRB_ESTADO)
                .IsRequired(false)
                .HasDefaultValue(true)
                .ValueGeneratedOnAdd();

            builder.Property(bore => bore.OPRB_ORDEN)
                .IsRequired(); // Opcional

   
        }
    }
}