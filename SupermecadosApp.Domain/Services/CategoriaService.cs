using SupermecadosApp.Domain.Dtos;
using SupermecadosApp.Domain.Interfaces.Repository;
using SupermecadosApp.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermecadosApp.Domain.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriasRepository;

        public CategoriaService(ICategoriaRepository categoriasRepository)
        {
            _categoriasRepository = categoriasRepository;
        }

        public List<CategoriaResponseDto> Consultar()
        {
            var categorias = _categoriasRepository.GetAll();
            var response = new List<CategoriaResponseDto>();

            foreach (var categoria in categorias)
            {
                response.Add(new CategoriaResponseDto
                {
                    Id = categoria.Id,
                    Nome = categoria.Nome
                });
            }

            return response;
        }
    }
}
