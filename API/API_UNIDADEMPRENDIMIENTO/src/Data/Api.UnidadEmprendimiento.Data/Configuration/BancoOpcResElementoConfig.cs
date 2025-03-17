using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class BancoOpcResElementoConfig : IEntityTypeConfiguration<BancoOpcResElemento>
    {
        public void Configure(EntityTypeBuilder<BancoOpcResElemento> builder)
        {
            builder.ToTable("BANCOOPCRESELEMENTO");

            builder.HasKey (bore=> bore.BORE_CODIGO);

            builder.Property(bore => bore.BORE_VALOR)
                .HasMaxLength(500);

            builder.Property(bore => bore.BORE_FECHARESPUESTA)
                .IsRequired();

            builder.Property(bore => bore.BORE_ESTADO)
                .IsRequired(false)
                .HasDefaultValue(true)
                .ValueGeneratedOnAdd();

            builder.Property(bore => bore.BORE_ORDEN)
                .IsRequired(false); // Opcional

   
        }
    }
}