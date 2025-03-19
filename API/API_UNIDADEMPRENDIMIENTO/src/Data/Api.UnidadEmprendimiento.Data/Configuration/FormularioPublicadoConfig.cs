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
    public class FormularioPublicadoConfig: IEntityTypeConfiguration<FormularioPublicado>
    {
        public void Configure(EntityTypeBuilder<FormularioPublicado> builder)
        {
        builder.ToTable("FORMULARIOPUBLICADO");

        builder.HasKey(f=> f.FORP_CODIGO);

        builder.Property(f=>f.FORP_NOMBRE)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(f=>f.FORP_DESCRIPCION)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(f=> f.FORP_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

        builder.HasMany(f => f.FORMULARIOSEP)
            .WithOne(fep => fep.FORMULARIOP)
            .HasForeignKey(fep => fep.FORP_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

     
        builder.HasMany(f => f.VERSIONESFP)
            .WithOne(vfp => vfp.FORMULARIOPUBLICADO)
            .HasForeignKey(vfp => vfp.FORP_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);
    
        }
    }
}