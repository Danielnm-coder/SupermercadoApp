using SupermecadosApp.Domain.Entities;
using SupermecadosApp.Domain.Interfaces.Repository;
using SupermecadosApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutosRepository
    {
        public void Add(Produto produto)
        {
            using (var dataContext = new DataContexts())
            {
                dataContext.Add(produto);
                dataContext.SaveChanges();
            }
        }

        public void Update(Produto produto)
        {
            using(var dataContext = new DataContexts())
            {
                dataContext.Update(produto);
                dataContext.SaveChanges();
            }
        }

        public void Delete(Guid Id)
        {
            using(var dataContexts = new DataContexts())
            {
               var produto = dataContexts.Set<Produto>().Find(Id);
                if (produto != null)
                {
                    dataContexts.Set<Produto>().Remove(produto);
                    dataContexts.SaveChanges();
                }

            }
        }

        public List<Produto> GetAll()
        {
            using (var datacontext = new DataContexts())
            {
                return datacontext 
                    .Set<Produto>()
                    .ToList();
            }
        }

        public Produto? GetById(Guid id)
        {
            using (var datacontext = new DataContexts())
            {
                return datacontext
                    .Set<Produto>()
                    .Find(id);
            }
        }

        public Produto GetByName(string nome)
        {
            using (var datacontext = new DataContexts())
            {
                return datacontext
                    .Set<Produto>()
                    .FirstOrDefault(p => p.Nome == nome);
            }
        }
    }
}
