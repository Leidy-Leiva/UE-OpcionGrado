using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class FormularioBorradorConfig: IEntityTypeConfiguration<FormularioBorrador>
    {
        public void Configure(EntityTypeBuilder<FormularioBorrador> builder)
        {
        builder.ToTable("FORMULARIOBORRADOR");

        builder.HasKey(f=> f.FORB_CODIGO);

        builder.Property(f=>f.FORB_NOMBRE)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(f=>f.FORB_DESCRIPCION)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(f=> f.FORB_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

        builder.HasMany(f => f.FORMULARIOSEB)
            .WithOne(fep => fep.FORMULARIOBORRADOR)
            .HasForeignKey(fep => fep.EFOB_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

    
        }
    }
}