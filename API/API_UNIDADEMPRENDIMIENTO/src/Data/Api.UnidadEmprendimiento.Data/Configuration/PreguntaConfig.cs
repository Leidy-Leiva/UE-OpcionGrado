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
    public class PreguntaConfig: IEntityTypeConfiguration<Pregunta>
    {
        public void Configure(EntityTypeBuilder<Pregunta> builder)
        {
            builder.ToTable("PREGUNTA");

            builder.HasKey(p=> p.PREG_CODIGO);

            builder.Property(p=> p.PREG_ENUNCIADO)
            .IsRequired()
            .HasMaxLength(300);

            builder.Property(p=> p.PREG_ORDEN)
            .IsRequired();

            
            builder.Property(p=> p.PREG_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

          
        }
    }
}