using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Domain.Dtos
{
    public class ProdutoRequestDto
    {


        [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo {1} caracteres")]
        [MinLength(8, ErrorMessage = "O campo nome deve ter no mínimo {1} caracteres")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string? Nome { get; set; }

        [Range(0.01, 999999999, ErrorMessage = "Por favor, informe o preço entrre {1} e {2}")]
        [Required(ErrorMessage = "O campo Preço é obrigatório")]
        public decimal? Preco { get; set; }

        [Range(0, 99999, ErrorMessage = "Por favor, informe a quantidade entre {1} e {2}")]
        [Required(ErrorMessage = "O campo Quantidade é obrigatório")]
        public int? QuantidadeEmEstoque { get; set; }

        [Required(ErrorMessage ="O Campo e CategoriaId e obrigatorio")]
        public Guid CategoriaId { get; set; }

    }
}
