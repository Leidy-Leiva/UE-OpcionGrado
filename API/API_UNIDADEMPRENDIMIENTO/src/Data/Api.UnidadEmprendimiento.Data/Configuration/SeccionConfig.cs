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
    public class SeccionConfig: IEntityTypeConfiguration<Seccion>
    {
        public void Configure(EntityTypeBuilder<Seccion> builder)
        {
            builder.ToTable("SECCION");

            builder.HasKey(s=> s.SECC_CODIGO);

            builder.Property(s=> s.SECC_NOMBRE)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(s=> s.SECC_ORDEN)
            .IsRequired();

            builder.Property(s=> s.SECC_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

            builder.HasMany(s=> s.PREGUNTAS)
            .WithOne(p=> p.SECCION)
            .HasForeignKey(p=> p.SECC_CODIGO);

            builder.HasOne(s=> s.FORMULARIO)
            .WithMany(f=> f.SECCIONES)
            .HasForeignKey(f=>f.FORM_CODIGO);
        }
    }
}