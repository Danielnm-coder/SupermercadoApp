using SupermecadosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Domain.Interfaces.Repository
{
    /// <summary>
    /// Definição dos metodos abstratos para o repositorio de produtos
    /// </summary>
    public interface IProdutosRepository
    {
        void Add(Produto produto);
        void Update(Produto produto); 
        void Delete(Guid produto);
        List<Produto> GetAll();
        Produto GetById(Guid Nome);
        Produto GetByName(string nome);
    }
}
