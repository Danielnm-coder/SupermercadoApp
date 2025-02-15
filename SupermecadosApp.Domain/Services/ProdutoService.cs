using SupermecadosApp.Domain.Dtos;
using SupermecadosApp.Domain.Entities;
using SupermecadosApp.Domain.Interfaces.Repository;
using SupermecadosApp.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Domain.Services
{
    /// <summary>
    /// Implementação da interface de serviço de domínio
    /// </summary>
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutosRepository _produtosRepository;

        public ProdutoService(IProdutosRepository produtosRepository)
        {
            _produtosRepository = produtosRepository;
        }

        public ProdutoResponseDto Cadastrar(ProdutoRequestDto dto)
        {
            var produtoExistente = _produtosRepository.GetByName(dto.Nome);
            if (produtoExistente != null)
            {
                throw new Exception("Já existe um produto cadastrado com este nome.");
            }

            var produto = new Produto()
            {
                Id = Guid.NewGuid(),
                Nome = dto.Nome,
                Preco = dto.Preco,
                QuantidadeEmEstoque = dto.QuantidadeEmEstoque,
                CategoriaId = dto.CategoriaId,
            };

            _produtosRepository.Add(produto);

            return new ProdutoResponseDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Preco = produto.Preco,
                QuantidadeEmEstoque = produto.QuantidadeEmEstoque,
                CategoriaId = produto.CategoriaId
            };
        }

        public ProdutoResponseDto Editar(ProdutoEditRequestDto dto)
        {
            var produto = _produtosRepository.GetById(dto.Id);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado.");
            }

            // Verifica se já existe um produto com o mesmo nome (exceto o próprio produto)
            var produtoExistente = _produtosRepository.GetByName(dto.Nome);
            if (produtoExistente != null && produtoExistente.Id != dto.Id)
            {
                throw new Exception("Já existe um produto cadastrado com este nome.");
            }

            produto.Nome = dto.Nome;
            produto.Preco = dto.Preco;
            produto.QuantidadeEmEstoque = dto.QuantidadeEmEstoque;
            produto.CategoriaId = dto.CategoriaId;

            _produtosRepository.Update(produto);

            return new ProdutoResponseDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Preco = produto.Preco,
                QuantidadeEmEstoque = produto.QuantidadeEmEstoque,
                CategoriaId = produto.CategoriaId
            };
        }

        public ProdutoResponseDto Excluir(Guid id)
        {
            var produto = _produtosRepository.GetById(id);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado.");
            }

            if (produto.QuantidadeEmEstoque > 0)
            {
                throw new Exception("Não é possível excluir um produto com estoque maior que 0.");
            }

            _produtosRepository.Delete(id);

            return new ProdutoResponseDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Preco = produto.Preco,
                QuantidadeEmEstoque = produto.QuantidadeEmEstoque,
                CategoriaId = produto.CategoriaId
            };
        }

        public List<ProdutoResponseDto> Consultar()
        {
            var produtos = _produtosRepository.GetAll();
            return produtos.Select(p => new ProdutoResponseDto
            {
                Id = p.Id,
                Nome = p.Nome,
                Preco = p.Preco,
                QuantidadeEmEstoque = p.QuantidadeEmEstoque,
                CategoriaId = p.CategoriaId
            }).ToList();
        }

        public ProdutoResponseDto ObterPorId(Guid id)
        {
            var produto = _produtosRepository.GetById(id);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado.");
            }

            return new ProdutoResponseDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Preco = produto.Preco,
                QuantidadeEmEstoque = produto.QuantidadeEmEstoque,
                CategoriaId = produto.CategoriaId
            };
        }
    }
}

