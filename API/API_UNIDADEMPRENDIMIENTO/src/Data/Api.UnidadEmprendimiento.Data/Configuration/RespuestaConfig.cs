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
    public class RespuestaConfig: IEntityTypeConfiguration<Respuesta>
    {
        public void Configure(EntityTypeBuilder<Respuesta> builder)
        {
            builder.ToTable("RESPUESTA");

            builder.HasKey(r=> r.RESP_CODIGO);

            builder.Property(r=> r.RESP_VALOR)
            .IsRequired()
            .HasMaxLength(150);

             builder.Property(r=> r.RESP_FECHARESPUESTA)
            .IsRequired();
           
            builder.Property(r=> r.RESP_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

            builder.HasOne(r=> r.PREGUNTA)
            .WithMany(p=> p.RESPUESTAS)
            .HasForeignKey(p=>p.PREG_CODIGO);

             builder.HasOne(r=> r.PROPUESTA)
            .WithMany(p=> p.RESPUESTAS)
            .HasForeignKey(p=>p.PROP_CODIGO);

        }
    }
}