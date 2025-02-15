using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Domain.Dtos
{
    public class ProdutoResponseDto
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? QuantidadeEmEstoque { get; set; }
        public decimal? Total { get { return Preco * QuantidadeEmEstoque; } }
        public Guid CategoriaId { get; set; }

    }
}
