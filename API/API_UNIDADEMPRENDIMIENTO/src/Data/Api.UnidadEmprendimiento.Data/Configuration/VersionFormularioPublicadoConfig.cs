using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_FORMULARIO.GEST_FORMULARIO_PUBLICADO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.UnidadEmprendimiento.Data.Configuration{
public class VersionFormularioPublicadoConfig : IEntityTypeConfiguration<VersionFormularioPublicado>
{
    public void Configure(EntityTypeBuilder<VersionFormularioPublicado> builder)
    {
        builder.ToTable("VERSIONFORMULARIOPUBLICADO");

        builder.HasKey(vfp => vfp.VFOP_CODIGO);

        builder.Property(vfp => vfp.VFOP_FECHA)
            .IsRequired();

        builder.Property(vfp => vfp.VFOP_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

        builder.HasMany(p=>p.PROPUESTASCOMENTARIOS)
            .WithOne(up=>up.VERSIONFP)
            .HasForeignKey(up=>up.PROC_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

    }
}

}