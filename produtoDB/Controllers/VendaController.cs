using Microsoft.AspNetCore.Mvc;
using produtoDB.DTO;
using produtoDB.Models;
using produtoDB.Repository;

namespace produtoDB.Controllers
{
    [ApiController]
    [Route("ApiController")]
    public class VendaController : ControllerBase
    {
        readonly private VendaRepository _vendaRepository;

        public VendaController(VendaRepository vendaRepository)
        {
            _vendaRepository =  vendaRepository;
        }



        [HttpGet("BuscaVendas")]
        public IActionResult BuscaVenda()
        {
            List<Venda> vendas = _vendaRepository.BuscaVenda();
            return Ok(vendas);
        }


        [HttpDelete("DeletaVenda")]
        public IActionResult DeletaVenda([FromQuery] int id)
        {
            _vendaRepository.DeletarVenda(id);
            return Ok(id);
        }

        [HttpPost("InserirVenda")]
        public IActionResult InserirVenda([FromBody] VendaInserirDTO dto)
        {
            _vendaRepository.InserirVenda(dto);
            return Ok();
        }

        [HttpPut("AtualizarVenda")]
        public IActionResult AtualizarVenda([FromBody] Venda venda)
        {
            _vendaRepository.AtualizarVenda(venda);
            return Ok();
        }
    }
}
