using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Domain.Entities
{
    public class Categoria
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }


        #region Relacionamento
        public List<Produto>? Produtos { get; set; }
        #endregion
    }
}
