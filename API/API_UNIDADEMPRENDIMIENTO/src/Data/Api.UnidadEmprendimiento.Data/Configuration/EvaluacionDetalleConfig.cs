using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class EvaluacionDetalleConfig: IEntityTypeConfiguration<EvaluacionDetalle>
    {
        public void Configure(EntityTypeBuilder<EvaluacionDetalle> builder)
        {
            builder.ToTable("EVALUACIONDETALLE");

            builder.HasKey(ed=> ed.EVDE_CODIGO);

            builder.Property(ed=> ed.EVDE_COMENTARIO)
            .IsRequired()
            .HasMaxLength(300);

            builder.Property(ed=>ed.EVDE_CALIFICACION);
            

            builder.Property(ed=> ed.EVDE_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();


        }
    }
}