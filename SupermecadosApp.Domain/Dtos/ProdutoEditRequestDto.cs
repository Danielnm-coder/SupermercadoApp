using System.ComponentModel.DataAnnotations;

public class ProdutoEditRequestDto
{
    public Guid Id { get; set; }

    [MaxLength(100, ErrorMessage = "O campo Nome deve ter no máximo {1} caracteres")]
    [MinLength(8, ErrorMessage = "O campo nome deve ter no mínimo {1} caracteres")]
    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    public string? Nome { get; set; }

    [Range(0.01, 999999999, ErrorMessage = "Por favor, informe o preço entre {1} e {2}")]
    [Required(ErrorMessage = "O campo Preço é obrigatório")]
    public decimal? Preco { get; set; }

    [Range(0, 99999, ErrorMessage = "Por favor, informe a quantidade entre {1} e {2}")]
    [Required(ErrorMessage = "O campo Quantidade é obrigatório")]
    public int? QuantidadeEmEstoque { get; set; }

    [Required(ErrorMessage = "O campo CategoriaId é obrigatório")]
    public Guid CategoriaId { get; set; }
}
