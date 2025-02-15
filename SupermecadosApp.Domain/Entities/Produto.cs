using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Domain.Entities
{
    /// <summary>
    /// Modelagem da entedade Supermecado
    /// </summary>
    public class Produto
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? QuantidadeEmEstoque { get; set; }
        public Guid CategoriaId { get; set; }


        #region Relacionamento
        public Categoria? Categoria { get; set; }

        #endregion

    }
}
