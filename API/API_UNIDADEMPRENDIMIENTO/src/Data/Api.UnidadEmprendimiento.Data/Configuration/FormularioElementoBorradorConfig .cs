using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_BORRADOR;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_PUBLICADO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class FormularioElementoBorradorConfig: IEntityTypeConfiguration<FormularioElementoBorrador>
    {   
        public void Configure(EntityTypeBuilder<FormularioElementoBorrador> builder)
        {
            builder.ToTable("FORMULARIOELEMENTOBORRADOR");

            builder.HasKey(fep=> fep.FOEB_CODIGO);

            builder.Property(fep=> fep.FOEB_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd(); 

        }

    }
}