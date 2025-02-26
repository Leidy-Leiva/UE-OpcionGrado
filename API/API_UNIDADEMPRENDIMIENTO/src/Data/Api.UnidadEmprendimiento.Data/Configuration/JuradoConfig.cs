using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_USUARIO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class JuradoConfig: IEntityTypeConfiguration<Jurado>
    {
        public void Configure(EntityTypeBuilder<Jurado> builder)
        {
            builder.ToTable("JURADO");

            builder.HasKey(j=> j.JURA_CODIGO);

            builder.Property(j=> j.JURA_PNOMBRE)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(j=> j.JURA_SNOMBRE)
            .HasMaxLength(50);

            builder.Property(j=> j.JURA_PAPELLIDO)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(j=> j.JURA_SAPELLIDO)
            .HasMaxLength(50);

            builder.Property(j=> j.JURA_CORREO)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(j=> j.JURA_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

            builder.HasMany(j=> j.EVALUACIONDETALLES)
            .WithOne(ed=> ed.JURADO)
            .HasForeignKey(ed=>ed.JURA_CODIGO);

             builder.HasMany(j=> j.PROPUESTASJURADOS)
            .WithOne(pj=> pj.JURADO)
            .HasForeignKey(pj=>pj.JURA_CODIGO);

        }
    }
}