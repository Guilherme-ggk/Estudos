using comercio_01.DTO;
using comercio_01.Models;
using comercio_01.Repository;
using Microsoft.AspNetCore.Mvc;

namespace comercio_01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepository _ProdutoRepository;

        public ProdutoController(ProdutoRepository ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
        }

        [HttpGet("BuscaProduto")]
        public IActionResult BuscaProduto()
        {
            List<Produto> Produtos = _ProdutoRepository.BuscaProdutos();
            return Ok(Produtos);
        }

        [HttpDelete("DeletaProdutos")]
        public IActionResult DeletaProdutos(int id)
        {
            _ProdutoRepository.DeletaProduto(id);
            return Ok();
        }

        [HttpPatch("AtualizaProdutos")]
        public IActionResult AtualizaProdutos(Produto Produto)
        {
            _ProdutoRepository.AtualizaProduto(Produto);
            return Ok();
        }

        [HttpPost("CriaProdutos")]
        public IActionResult CriaProdutos(ProdutoInserirDTO dto)
        {
            _ProdutoRepository.CriaProduto(dto);
            return Ok();
        }
    }
}