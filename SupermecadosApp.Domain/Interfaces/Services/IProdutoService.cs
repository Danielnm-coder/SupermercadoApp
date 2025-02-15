using SupermecadosApp.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        ProdutoResponseDto Cadastrar(ProdutoRequestDto dto);
        ProdutoResponseDto Editar(ProdutoEditRequestDto dto);
        ProdutoResponseDto Excluir(Guid id);
        List<ProdutoResponseDto> Consultar();
        ProdutoResponseDto ObterPorId(Guid id);
        
    }
}
