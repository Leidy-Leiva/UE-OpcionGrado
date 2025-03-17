using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GES_BANCO_FORMULARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class BancoFormularioConfig: IEntityTypeConfiguration<BancoFormulario>
    {
        public void Configure(EntityTypeBuilder<BancoFormulario> builder)
        {
        builder.ToTable("BANCOFORMULARIO");

        builder.HasKey(f=> f.BANF_CODIGO);

        builder.Property(f=>f.BANF_NOMBRE)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(f=>f.BANF_DESCRIPCION)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(f=> f.BANF_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

        builder.HasMany(f => f.BFORMULARIOSE)
            .WithOne(fep => fep.FORMULARIO)
            .HasForeignKey(fep => fep.BANF_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

    
        }
    }
}