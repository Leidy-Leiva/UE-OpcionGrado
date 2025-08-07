using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BancoFormularioElementoConfig : IEntityTypeConfiguration<BancoFormularioElemento>
{
    public void Configure(EntityTypeBuilder<BancoFormularioElemento> builder)
    {
        // Nombre de la tabla en la base de datos
        builder.ToTable("BANCOFORMULARIOELEMENTO");

        // Definición de la clave primaria
        builder.HasKey(bfe => bfe.BFOE_CODIGO);

        // Configuración de la propiedad opcional
           builder.Property(f=> f.BFOE_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();
       
    }
}
