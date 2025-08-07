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
    public class ConvocatoriaConfig:IEntityTypeConfiguration<Convocatoria>
    {
        public void Configure (EntityTypeBuilder<Convocatoria> builder)
        {
            builder.ToTable("CONVOCATORIA");

            builder.HasKey (c=> c.CONV_CODIGO);

            builder.Property(c=> c.CONV_FECHAINICIO)
            .IsRequired();

            builder.Property(c=> c.CONV_FECHAFIN)
            .IsRequired();

            builder.Property(c=> c.CONV_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd(); 

            builder.HasMany(c=>c.PROPUESTAS)
            .WithOne(p=> p.CONVOCATORIA)
            .HasForeignKey(p=> p.CONV_CODIGO);

            builder.HasMany(c=>c.CONVOCATORIASFORMULARIOS)
            .WithOne(cf=> cf.CONVOCATORIA)
            .HasForeignKey(cf=> cf.CONV_CODIGO);
           

        }
    }
}