using Microsoft.AspNetCore.Mvc;
using produtoDB.DTO;
using produtoDB.Models;
using produtoDB.Repository;

namespace produtoDB.Controllers
{
    [ApiController]
    [Route("ApiController")]
    public class CategoriaController : ControllerBase
    {
        readonly private CategoriaRepository _categoriaRepository;

        public CategoriaController (CategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }



        [HttpGet("BuscaCategoria")]
        public IActionResult BuscaCategoria()
        {
            List<Categoria> categorias = _categoriaRepository.BuscaCategoria();
            return Ok(categorias);
        }


        [HttpDelete("DeletaCategoria")]
        public IActionResult DeletaCategoria([FromQuery] int id)
        {
            _categoriaRepository.DeletarCategoria(id);
            return Ok(id);
        }

        [HttpPost("InserirCategoria")]
        public IActionResult InserirCategoria([FromBody] CategoriaInserirDTO dto)
        {
            _categoriaRepository.InserirCategoria(dto);
            return Ok();
        }

        [HttpPut("AtualizarCategoria")]
        public IActionResult AtualizarCategoria([FromBody] Categoria categoria)
        {
            _categoriaRepository.AtualizarCategoria(categoria);
            return Ok();
        }
    }
}
