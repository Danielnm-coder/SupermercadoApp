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
    /// <summary>
    /// Classe de mapeamento para entidade de produto
    /// </summary>
    public   class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTOS");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasIndex(p => p.Nome)
                .IsUnique();

            builder.Property(p => p.Preco)
                .HasColumnName("PRECO")
                .HasColumnType("decimal(10,2)")
                .IsRequired()
                .HasDefaultValue(0m);

            builder.Property(p => p.QuantidadeEmEstoque)
                .HasColumnName("QUANTIDADEEMESTOQUE")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.CategoriaId)
                .HasColumnName("CATEGOTIA_ID")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            builder.HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId);

        }
    }
}
