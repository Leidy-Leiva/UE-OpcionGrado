using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class ConvocatoriaPublicadaConfig:IEntityTypeConfiguration<ConvocatoriaPublicada>
    {
        public void Configure (EntityTypeBuilder<ConvocatoriaPublicada> builder)
        {
            builder.ToTable("CONVOCATORIAPUBLICADA");

            builder.HasKey (c=> c.CONP_CODIGO);

            builder.Property(c=> c.CONP_FECHAINICIO)
            .IsRequired();

            builder.Property(c=> c.CONP_FECHAFIN)
            .IsRequired();

            builder.Property(c=> c.CONP_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd(); 

            builder.HasMany(c=>c.PROPUESTAS)
            .WithOne(p=> p.CONVOCATORIAP)
            .HasForeignKey(p=> p.CONP_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(cp=>cp.FORMULARIOSPUBLICADOS)
            .WithOne(fp=> fp.CONVOCATORIAPUBLICADA)
            .HasForeignKey(fp=> fp.CONP_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

           

        }
    }
}