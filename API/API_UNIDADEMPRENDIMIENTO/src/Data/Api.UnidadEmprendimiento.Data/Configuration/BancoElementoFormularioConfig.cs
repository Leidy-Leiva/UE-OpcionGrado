
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Api.UnidadEmprendimiento.Data.Configuration
{
public class BancoElementoFormularioConfig : IEntityTypeConfiguration<BancoElementoFormulario>
    {
        public void Configure(EntityTypeBuilder<BancoElementoFormulario> builder)
        {
            builder.ToTable("BANCOELEMENTOFORMULARIO");

            builder.HasKey(bef => bef.BEFO_CODIGO);

            builder.Property(bef=> bef.BEFO_ENUNCIADO)
                .HasMaxLength(500);

            builder.Property(bef => bef.BEFO_ORDEN)
                .IsRequired();

            builder.Property(bef => bef.BEFO_ESTADO)
                .IsRequired()
                .HasDefaultValue(true)
                .ValueGeneratedOnAdd();

            builder.Property(bef => bef.BEFO_DATOSJSON)
                .HasColumnType("TEXT"); // Puede cambiar según el motor de BD


            builder.HasMany(efp => efp.BANCOOPCRESELEMENTOS)
                .WithOne(opr => opr.BELEMENTOF)
                .HasForeignKey(opr => opr.BEFO_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(f => f.BFORMULARIOSE)
                .WithOne(fep => fep.ELEMENTOFORMULARIO)
                .HasForeignKey(fep => fep.BEFO_CODIGO)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }







}