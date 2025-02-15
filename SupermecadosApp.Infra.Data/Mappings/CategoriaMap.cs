using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupermecadosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Infra.Data.Mappings
{
    public class CategoriaMap :IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("CATEGORIAS");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            builder.HasIndex(c => c.Nome)
                .IsUnique();
        }
    }
}
