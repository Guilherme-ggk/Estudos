using comercio_01.DTO;
using comercio_01.Models;
using comercio_01.Repository;
using Microsoft.AspNetCore.Mvc;

namespace comercio_01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly CategoriaRepository _categoriarepository;

        public CategoriaController(CategoriaRepository categoriaRepository)
        {
            _categoriarepository = categoriaRepository;
        }

        [HttpPost("CriarCategoria")]
        public IActionResult CriaCategoria(CategoriaInserirDTO categoria)
        {
            _categoriarepository.CriaCategoria(categoria);
            return Ok();
        }

        [HttpDelete("DeleteCategoria")]
        public IActionResult DeleteCategoria(int id)
        {
            _categoriarepository.DeletaCategoria(id);
            return Ok();
        }

        [HttpPatch("AtualizaCategoria")]
        public IActionResult AtualizaCategoria([FromBody] Categoria categoria)
        {
            _categoriarepository.AtualizaCategoria(categoria);
            return Ok();
        }

        [HttpGet("BuscaCategoria")]
        public IActionResult BuscaCategoria()
        {
            List<Categoria> categorias = _categoriarepository.BuscaCategoria();
            return Ok(categorias);
        }
    }
}