using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_PUBLICADO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class FormularioElementoPublicadoConfig: IEntityTypeConfiguration<FormularioElementoPublicado>
    {   
        public void Configure(EntityTypeBuilder<FormularioElementoPublicado> builder)
        {
            builder.ToTable("FORMULARIOELEMENTOPUBLICADO");

            builder.HasKey(fep=> fep.FOEP_CODIGO);

            builder.Property(fep=> fep.FOEP_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd(); 

        }

    }
}