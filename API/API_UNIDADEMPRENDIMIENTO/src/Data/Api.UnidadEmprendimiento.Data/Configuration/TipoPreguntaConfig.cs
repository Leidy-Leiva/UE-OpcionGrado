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
    public class TipoPreguntaConfig: IEntityTypeConfiguration<TipoPregunta>
    {
        public void Configure(EntityTypeBuilder<TipoPregunta> builder)
        {
            builder.ToTable("TIPOPREGUNTA");

            builder.HasKey(tp=> tp.TIPR_CODIGO);

            builder.Property(tp=> tp.TIPR_NOMBRE)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(tp=> tp.TIPR_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd(); 

            builder.HasMany(tp=> tp.PREGUNTAS)
            .WithOne(p=> p.TIPOPREGUNTA)
            .HasForeignKey(f=>f.TIPR_CODIGO);

        }
    }
}