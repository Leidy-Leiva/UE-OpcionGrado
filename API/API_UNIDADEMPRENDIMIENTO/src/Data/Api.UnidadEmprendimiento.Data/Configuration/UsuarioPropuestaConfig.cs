using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class UsuarioPropuestaConfig :IEntityTypeConfiguration<UsuarioPropuesta>
    {
        public void Configure(EntityTypeBuilder<UsuarioPropuesta> builder)
        {
            builder.ToTable("USUARIOPROPUESTA");

            builder.HasKey(up=> up.USUP_CODIGO);

            builder.Property(up=> up.USUP_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

            builder.Property(up=> up.USUP_FECHAASOCIACION);

            builder.Property(u=> u.PERS_CODIGO)
            .IsRequired();


        }




    }


}