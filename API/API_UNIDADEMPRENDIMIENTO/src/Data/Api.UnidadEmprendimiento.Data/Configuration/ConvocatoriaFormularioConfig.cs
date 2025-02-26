using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class ConvocatoriaFormularioconfig: IEntityTypeConfiguration<ConvocatoriaFormulario>
    {
        public void Configure(EntityTypeBuilder<ConvocatoriaFormulario> builder)
        {
            builder.ToTable("CONVOCATORIAFORMULARIO");

            builder.HasKey(cf=> cf.COFO_CODIGO);

            builder.Property(cf=> cf.COFO_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd(); 

        }
    }
}