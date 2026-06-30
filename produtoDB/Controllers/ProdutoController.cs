using Microsoft.AspNetCore.Mvc;
using produtoDB.DTO;
using produtoDB.Models;
using produtoDB.Repository;

namespace produtoDB.Controllers
{
    [ApiController]
    [Route("ApiController")]
    public class ProdutoController : ControllerBase
    {
        readonly private ProdutoRepository _produtoRepository;

        public ProdutoController(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpPost("InserirProduto")]
        public IActionResult InserirProduto([FromBody] ProdutoInserirDTO dto)
        {
            _produtoRepository.InserirProduto(dto);
            return Ok();
        }

        [HttpDelete("DeletaProduto")]
        public IActionResult DeletarProduto([FromQuery] int id)
        {
            _produtoRepository.DeleteProduto(id);
            return Ok();
        }

        [HttpGet("ConsultaProduto")]
        public IActionResult ConsultaProduto()
        {
            List<Produto> produtos = _produtoRepository.ConsultaProduto();
            return Ok(produtos);
        }

        [HttpPut("AtualizarProduto")]
        public IActionResult AtualizarProduto(Produto produto)
        {
            _produtoRepository.AtualizarProduto(produto);
            return Ok();
        }
    }
}
