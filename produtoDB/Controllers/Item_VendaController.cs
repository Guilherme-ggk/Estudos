using Microsoft.AspNetCore.Mvc;
using produtoDB.DTO;
using produtoDB.Models;
using produtoDB.Repository;

namespace produtoDB.Controllers
{
    [ApiController]
    [Route("ApiController")]
    public class Item_VendaController : ControllerBase
    {
        readonly private Item_VendaRepository _item_vendaRepository;

        public Item_VendaController(Item_VendaRepository item_vendaRepository)
        {
            _item_vendaRepository = item_vendaRepository;
        }

        [HttpGet("ConsultaItem_venda")]
        public ActionResult ConsultaItem_Venda()
        {
            List<Item_Venda> item_vendas = _item_vendaRepository.ConsultarItem_Venda();
            return Ok(item_vendas);
        }


        [HttpDelete("DeletaItem_Vendas")]
        public IActionResult DeletaFornecedor([FromQuery] int id)
        {
            _item_vendaRepository.DeletarItem_Venda(id);
            return Ok();
        }

        [HttpPost("InserirItem_Venda")]
        public IActionResult InserirItem_Venda([FromBody] Item_VendaInserirDTO dto)
        {
            _item_vendaRepository.InserirItem_Venda(dto);
            return Ok();
        }

        [HttpPut("AtualizaItem_Venda")]
        public IActionResult AtualizaFornecedor([FromBody] Item_Venda item_Venda)
        {
            _item_vendaRepository.AtualizarItem_Venda(item_Venda);
            return Ok();
        }
    }
}
