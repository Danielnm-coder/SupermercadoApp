using SupermecadosApp.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Domain.Interfaces.Services
{
    public interface ICategoriaService
    {
        List<CategoriaResponseDto> Consultar();
    }
}
