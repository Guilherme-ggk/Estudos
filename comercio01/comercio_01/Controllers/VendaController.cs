using comercio_01.DTO;
using comercio_01.Models;
using comercio_01.Repository;
using Microsoft.AspNetCore.Mvc;

namespace comercio_01.Controllers
{
    public class VendaController : ControllerBase
    {
        private readonly VendaRepository _VendaRepository;

        public VendaController(VendaRepository VendaRepository)
        {
            _VendaRepository = VendaRepository;
        }

        [HttpGet("BuscaVenda")]
        public IActionResult BuscaVenda()
        {
            List<Venda> Vendas = _VendaRepository.BuscaVendas();
            return Ok(Vendas);
        }

        [HttpDelete("DeletaVendas")]
        public IActionResult DeletaVendas(int id)
        {
            _VendaRepository.DeletaVenda(id);
            return Ok();
        }

        [HttpPatch("AtualizaVendas")]
        public IActionResult AtualizaVendas(Venda Venda)
        {
            _VendaRepository.AtualizaVenda(Venda);
            return Ok();
        }

        [HttpPost("CriaVendas")]
        public IActionResult CriaVendas(VendaInserirDTO dto)
        {
            _VendaRepository.CriaVenda(dto);
            return Ok();
        }
    }
}