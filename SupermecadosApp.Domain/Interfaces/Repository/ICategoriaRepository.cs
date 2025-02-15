using SupermecadosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Domain.Interfaces.Repository
{
    public interface ICategoriaRepository
    {
        List<Categoria> GetAll();
    }
}
