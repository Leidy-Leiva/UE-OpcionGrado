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
    public class EvaluacionConfig: IEntityTypeConfiguration<Evaluacion>
    {
        public void Configure(EntityTypeBuilder<Evaluacion> builder)
        {
            builder.ToTable("EVALUACION");

            builder.HasKey(e=> e.EVAL_CODIGO);

            builder.Property(e=> e.EVAL_PROMEDIOCALIFICACION)
            .IsRequired();

            builder.Property(e=> e.EVAL_FECHACALIFICACION)
            .IsRequired();

            builder.Property(e=> e.EVAL_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

            builder.HasMany(e=> e.EVALUACIONDETALLES)
            .WithOne(ed=> ed.EVALUACION)
            .HasForeignKey(ed=>ed.EVAL_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

             builder.HasMany(e=> e.ITEMS)
            .WithOne(ed=> ed.EVALUACION)
            .HasForeignKey(ed=>ed.EVAL_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

            

        }
    }
}