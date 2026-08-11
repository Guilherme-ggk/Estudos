using comercio_01.DTO;
using comercio_01.Models;
using comercio_01.Repository;
using Microsoft.AspNetCore.Mvc;

namespace comercio_01.Controllers
{
    public class Item_VendaController : Controller
    {
        private readonly Item_VendaRepository _Item_VendaRepository;

        public Item_VendaController(Item_VendaRepository Item_VendaRepository)
        {
            _Item_VendaRepository = Item_VendaRepository;
        }

        [HttpGet("BuscaItem_Venda")]
        public IActionResult BuscaItem_Venda()
        {
            List<Item_Venda> Item_Vendas = _Item_VendaRepository.BuscaItem_Vendas();
            return Ok(Item_Vendas);
        }

        [HttpDelete("DeletaItem_Vendas")]
        public IActionResult DeletaItem_Vendas(int id)
        {
            _Item_VendaRepository.DeletaItem_Venda(id);
            return Ok();
        }

        [HttpPatch("AtualizaItem_Vendas")]
        public IActionResult AtualizaItem_Vendas(Item_Venda Item_Venda)
        {
            _Item_VendaRepository.AtualizaItem_Venda(Item_Venda);
            return Ok();
        }

        [HttpPost("CriaItem_Vendas")]
        public IActionResult CriaItem_Vendas(Item_VendaInserirDTO dto)
        {
            _Item_VendaRepository.CriaItem_Venda(dto);
            return Ok();
        }
    }
}