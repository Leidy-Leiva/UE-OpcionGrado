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
    public class EstadoPropuestaConfig: IEntityTypeConfiguration<EstadoPropuesta>
    {
        public void Configure(EntityTypeBuilder<EstadoPropuesta> builder)
        {
            builder.ToTable("ESTADOPROPUESTA");

            builder.HasKey(ep=> ep.ESTP_CODIGO);

            builder.Property(ep=> ep.ESTP_NOMBRE)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(ep=> ep.ESTP_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd(); 

            builder.HasMany(ep=> ep.PROPUESTAS)
            .WithOne(p=> p.ESTADOPROPUESTA)
            .HasForeignKey(p=>p.ESTP_CODIGO);

        }
    }
}