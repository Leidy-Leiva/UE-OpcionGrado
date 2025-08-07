using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class ConvocatoriaBorradorConfig:IEntityTypeConfiguration<ConvocatoriaBorrador>
    {
        public void Configure (EntityTypeBuilder<ConvocatoriaBorrador> builder)
        {
            builder.ToTable("CONVOCATORIABORRADOR");

            builder.HasKey (c=> c.CONB_CODIGO);

            builder.Property(c=> c.CONB_FECHAINICIO)
            .IsRequired();

            builder.Property(c=> c.CONB_FECHAFIN)
            .IsRequired();

            builder.Property(c=> c.CONB_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd(); 

            builder.HasMany(cb=>cb.FORMULARIOSBORRADOR)
            .WithOne(fb=> fb.CONVOCATORIABORRADOR)
            .HasForeignKey(fb=> fb.CONB_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

      

           

        }
    }
}