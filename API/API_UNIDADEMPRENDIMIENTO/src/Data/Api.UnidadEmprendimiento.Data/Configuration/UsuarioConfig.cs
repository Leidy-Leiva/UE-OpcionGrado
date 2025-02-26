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
    public class UsuarioConfig: IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO");

            builder.HasKey(u=> u.USUA_CODIGO);

            builder.Property(u=> u.USUA_PNOMBRE)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(u=> u.USUA_SNOMBRE)
            .HasMaxLength(50);

            builder.Property(u=> u.USUA_PAPELLIDO)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(u=> u.USUA_SAPELLIDO)
            .HasMaxLength(50);

            builder.Property(u=> u.USUA_NOMBREUSUARIO)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(u=> u.USUA_CONTRASENIA)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(u=> u.USUA_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

            builder.Property(u=> u.PERS_PEGEID)
            .IsRequired();


        }
    }
}