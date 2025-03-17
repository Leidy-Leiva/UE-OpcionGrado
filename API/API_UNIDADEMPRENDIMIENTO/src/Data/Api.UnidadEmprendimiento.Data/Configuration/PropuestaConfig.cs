using Api.UnidadEmprendimiento.Domain.Entities.SQL_SERVER.GEST_PROPUESTA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnidadEmprendimiento.Data.Configuration
{
    public class PropuestaConfig: IEntityTypeConfiguration<Propuesta>
    {
        public void Configure(EntityTypeBuilder<Propuesta> builder)
        {
            builder.ToTable("PROPUESTA");

            builder.HasKey(p=> p.PROP_CODIGO);

            builder.Property(p=> p.PROP_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();


            builder.Property(p=> p.SALA_CODIGO)
            .IsRequired();
            
            builder.HasMany(p=>p.RESPUESTAS)
            .WithOne(r=>r.PROPUESTA)
            .HasForeignKey(r=>r.PROP_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p=> p.PROPUESTASJURADOS)
            .WithOne(pp=> pp.PROPUESTA)
            .HasForeignKey(pp=>pp.PROP_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);
            

            builder.HasMany(p=> p.EVALUACIONDETALLES)
            .WithOne(ed=> ed.PROPUESTA)
            .HasForeignKey(ed=>ed.PROP_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);


            builder.HasMany(p=>p.VERSIONES)
            .WithOne(v=>v.PROPUESTA)
            .HasForeignKey(v=>v.VERS_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p=>p.USUARIOSPROPUESTAS)
            .WithOne(up=>up.PROPUESTA)
            .HasForeignKey(up=>up.PERS_CODIGO)
            .OnDelete(DeleteBehavior.Restrict);

            

        }
    }
}