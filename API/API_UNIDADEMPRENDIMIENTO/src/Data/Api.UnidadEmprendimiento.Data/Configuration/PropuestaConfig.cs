using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class PropuestaConfig: IEntityTypeConfiguration<Propuesta>
    {
        public void Configure(EntityTypeBuilder<Propuesta> builder)
        {
            builder.ToTable("PROPUESTA");

            builder.HasKey(p=> p.PROP_CODIGO);

            builder.Property(p=> p.PROP_TITULO)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p=> p.PROP_DESCRIPCION)
            .IsRequired()
            .HasMaxLength(300);

            builder.Property(p=> p.PROP_PRESENTACION)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(p=> p.PROP_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();


            builder.Property(p=> p.SALA_CODIGO)
            .IsRequired();
            

            builder.HasMany(p=> p.PROPUESTASJURADOS)
            .WithOne(ed=> ed.PROPUESTA)
            .HasForeignKey(ed=>ed.PROP_CODIGO);
            

            builder.HasMany(p=> p.EVALUACIONDETALLES)
            .WithOne(ed=> ed.PROPUESTA)
            .HasForeignKey(ed=>ed.PROP_CODIGO);

            

        }
    }
}