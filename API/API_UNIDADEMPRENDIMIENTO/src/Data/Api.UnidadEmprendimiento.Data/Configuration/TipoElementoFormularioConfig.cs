using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class TipoElementoFormularioConfig : IEntityTypeConfiguration<TipoElementoFormulario>
    {
        public void Configure(EntityTypeBuilder<TipoElementoFormulario> builder)
        {
            builder.ToTable("TIPOELEMENTOFORMULARIO");

            builder.HasKey(tef => tef.TPEF_CODIGO);

            builder.Property(tef => tef.TPEF_NOMBRE)
                .HasMaxLength(100);

            builder.Property(tef => tef.TPEF_ESTADO)
                .IsRequired()
                .HasDefaultValue(true)
                .ValueGeneratedOnAdd();

           
            builder.HasMany(tef => tef.ELEMENTOSFP)
                .WithOne(efp => efp.TIPOELEMENTOF)
                .HasForeignKey(efp => efp.TEFO_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(tef => tef.ELEMENTOSFB)
                .WithOne(efb => efb.TIPOELEMENTOF)
                .HasForeignKey(efb => efb.TEFO_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);
                

            builder.HasMany(tef => tef.BELEMENTOSF)
                .WithOne(bef => bef.TIPOELEMENTOF)
                .HasForeignKey(bef => bef.TEFO_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
