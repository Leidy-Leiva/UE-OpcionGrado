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
    public class TipoFormularioConfig: IEntityTypeConfiguration<TipoFormulario>
    {
        public void Configure(EntityTypeBuilder<TipoFormulario> builder)
        {
            builder.ToTable("TIPOFORMULARIO");

            builder.HasKey(tf=> tf.TIPF_CODIGO);

            builder.Property(tf=> tf.TIPF_NOMBRE)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(tf=> tf.TIPF_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

            builder.HasMany(tf=> tf.FORMULARIOS)
            .WithOne(f=> f.TIPOFORMULARIO)
            .HasForeignKey(f=>f.TIPF_CODIGO);

        }
    }
}