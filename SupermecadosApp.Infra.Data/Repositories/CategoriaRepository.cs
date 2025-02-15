using SupermecadosApp.Domain.Entities;
using SupermecadosApp.Domain.Interfaces.Repository;
using SupermecadosApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Infra.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public List<Categoria> GetAll()
        {
            using (var datacontext = new DataContexts())
            {
                return datacontext
                    .Set<Categoria>()
                    .OrderBy(c => c.Nome)
                    .ToList(); 
            }
        }
    }
}
