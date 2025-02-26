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
    public class FormularioConfig: IEntityTypeConfiguration<Formulario>
    {
        public void Configure(EntityTypeBuilder<Formulario> builder)
        {
        builder.ToTable("FORMULARIO");

        builder.HasKey(f=> f.FORM_CODIGO);

        builder.Property(f=>f.FORM_NOMBRE)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(f=>f.FORM_DESCRIPCION)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(f=> f.FORM_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

            builder.HasMany(f=>f.CONVOCATORIASFORMULARIOS)
            .WithOne(cf=> cf.FORMULARIO)
            .HasForeignKey(cf=> cf.FORM_CODIGO);

    
        }
    }
}