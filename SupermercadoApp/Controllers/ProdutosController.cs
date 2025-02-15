using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupermecadosApp.Domain.Dtos;
using SupermecadosApp.Domain.Interfaces.Services;
using System.ComponentModel.DataAnnotations;

namespace SupermercadoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        /// <summary>
        /// Serviço para cadastro de produtos
        /// </summary>
        [ProducesResponseType(typeof(ProdutoResponseDto),201)]
        [HttpPost]
        public IActionResult Post([FromBody] ProdutoRequestDto dto)
        {

            try
            {
                var response = _produtoService.Cadastrar(dto);
                return StatusCode(201, response);
            }
            catch (ApplicationException e)
            {
                return StatusCode(422, new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        /// <summary>
        /// Serviço para edição de produtos
        /// </summary>
        [ProducesResponseType(typeof(ProdutoResponseDto), 200)]
        [HttpPut]
        public IActionResult Put([FromBody] ProdutoEditRequestDto dto)
        {
            try
            {
                var response = _produtoService.Editar(dto);
                return Ok(response);
            }
            catch (ApplicationException e)
            {
                return StatusCode(422, new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        /// <summary>
        /// Serviço para exclusão de produtos
        /// </summary>
        [ProducesResponseType(typeof(ProdutoResponseDto), 200)]
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var response = _produtoService.Excluir(id);
                return Ok(response);
            }
            catch (ApplicationException e)
            {
                return StatusCode(422, new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        /// <summary>
        /// Serviço para consulta de todos os produtos
        /// </summary>
        [ProducesResponseType(typeof(List<ProdutoResponseDto>), 200)]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var response = _produtoService.Consultar();
                return Ok(response);
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        /// <summary>
        /// Serviço para consulta de um produto por ID
        /// </summary>
        [ProducesResponseType(typeof(ProdutoResponseDto), 200)]
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                var response = _produtoService.ObterPorId(id);
                return Ok(response);
            }
            catch (ApplicationException e)
            {
                return StatusCode(422, new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }
    }
}
