using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupermecadosApp.Domain.Interfaces.Services;
using SupermecadosApp.Domain.Dtos;

namespace SupermercadoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaservice)
        {
            _categoriaService = categoriaservice;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categorias = _categoriaService.Consultar();
            var response = new List<CategoriaResponseDto>();

            foreach (var categoria in categorias)
            {
                response.Add(new CategoriaResponseDto
                {
                    Id = categoria.Id,
                    Nome = categoria.Nome
                });
            }

            return Ok(response);
        }
    }
}



