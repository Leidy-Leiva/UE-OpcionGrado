using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_EVALUACION;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class PropuestaJuradoConfig: IEntityTypeConfiguration<PropuestaJurado>
    {
        public void Configure(EntityTypeBuilder<PropuestaJurado> builder)
        {
            builder.ToTable("PROPUESTAJURADO");

            builder.HasKey(pj=> pj.PROJ_CODIGO);

            builder.Property(pj=> pj.PROJ_FECHAASIGNACION)
            .IsRequired();

            builder.Property(pj=> pj.PROPJ_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();

        }
    }
}