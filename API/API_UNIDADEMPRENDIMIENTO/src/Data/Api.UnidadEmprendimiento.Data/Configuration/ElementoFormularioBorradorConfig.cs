using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ElementoFormularioBorradorConfig : IEntityTypeConfiguration<ElementoFormularioBorrador>
{
    public void Configure(EntityTypeBuilder<ElementoFormularioBorrador> builder)
    {
        builder.ToTable("ELEMENTOFORMULARIOBORRADOR");

        builder.HasKey(e => e.EFOB_CODIGO);

        builder.Property(e => e.EFOB_ENUNCIADO)
               .HasMaxLength(500);

        // Si EFOB_ORDEN es nullable en la entidad, se configura como opcional
        builder.Property(e => e.EFOB_ORDEN)
               .IsRequired(false);

        builder.Property(e => e.EFOB_ESTADO)
               .IsRequired(false)
               .HasDefaultValue(true)
               .ValueGeneratedOnAdd();

        builder.Property(e => e.EFOB_DATOSJSON)
               .HasColumnType("TEXT");

        builder.HasMany(efp => efp.OPCRESPUESTASBORRADOR)
                .WithOne(opr => opr.ELEMENTOFB)
                .HasForeignKey(opr => opr.EFOB_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);
                
        builder.HasMany(efp => efp.FORMULARIOEB)
                .WithOne(opr => opr.ELEMENTOBORRADOR)
                .HasForeignKey(opr => opr.EFOB_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);
    }
}
