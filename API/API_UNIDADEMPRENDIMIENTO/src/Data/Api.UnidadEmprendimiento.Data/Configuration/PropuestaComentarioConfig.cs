using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.UnidadEmprendimiento.Data.Configuration{
public class PropuestaComentarioConfig : IEntityTypeConfiguration<PropuestaComentario>
{
    public void Configure(EntityTypeBuilder<PropuestaComentario> builder)
    {
        builder.ToTable("PROPUESTA_COMENTARIO");

        builder.HasKey(pc => pc.PROC_CODIGO);

        builder.Property(pc => pc.PROC_FECHACREACION)
               .IsRequired();

        builder.Property(pc => pc.PROC_COMENTARIO)
               .HasMaxLength(500); 

       
    }
}

}