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
    public class ItemConfig: IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("ITEM");

            builder.HasKey(i=> i.ITEM_CODIGO);

            builder.Property(i=> i.ITEM_NOMBRE)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(i=> i.ITEM_PUNTAJEMAXIMO)
            .IsRequired();

            builder.Property(i=> i.ITEM_COMENTARIO)
            .IsRequired()
            .HasMaxLength(300);

            builder.Property(i=> i.ITEM_ESTADO)
            .IsRequired()
            .HasDefaultValue(true)
            .ValueGeneratedOnAdd();



        }
    }
}