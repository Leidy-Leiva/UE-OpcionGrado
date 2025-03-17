
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Api.UnidadEmprendimiento.Data.Configuration
{
public class ElementoFormularioPublicadoConfig : IEntityTypeConfiguration<ElementoFormularioPublicado>
    {
        public void Configure(EntityTypeBuilder<ElementoFormularioPublicado> builder)
        {
            builder.ToTable("ELEMENTOFORMULARIOPUBLICADO");

            builder.HasKey(efp => efp.EFOP_CODIGO);

            builder.Property(efp => efp.EFOP_ENUNCIADO)
                .HasMaxLength(500);

            builder.Property(efp => efp.EFOP_ORDEN)
                .IsRequired(false);

            builder.Property(efp => efp.EFOP_ESTADO)
                .IsRequired(false)
                .HasDefaultValue(true)
                .ValueGeneratedOnAdd();

            builder.Property(efp => efp.EFOP_DATOSJSON)
                .HasColumnType("TEXT"); // Puede cambiar según el motor de BD


            builder.HasMany(efp => efp.OPCRESPUESTASPUBLICADOS)
                .WithOne(opr => opr.ELEMENTOFP)
                .HasForeignKey(opr => opr.EFOP_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);
                
            builder.HasMany(efp => efp.FORMULARIOSEP)
                .WithOne(opr => opr.ELEMENTOFP)
                .HasForeignKey(opr => opr.EFOP_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(efp => efp.RESPUESTAS)
                .WithOne(resp => resp.ELEMENTOFP)
                .HasForeignKey(resp => resp.EFOP_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }







}