using Microsoft.AspNetCore.Mvc;
using produtoDB.DTO;
using produtoDB.Models;
using produtoDB.Repository;

namespace produtoDB.Controllers
{
    [ApiController]
    [Route("ApiController")]
    public class FornecedorController : ControllerBase
    {
        readonly private FornecedorRepository _fornecedorRepository;

        public FornecedorController(FornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        [HttpGet("ConsultaFornecedor")]
        public ActionResult ConsultaFornecedor()
        {
            List<Fornecedor> fornecedors = _fornecedorRepository.ConsultaFornecedores();
            return Ok(fornecedors);
        }


        [HttpDelete("DeletaFornecedor")]
        public IActionResult DeletaFornecedor([FromQuery] int id)
        {
            _fornecedorRepository.DeletarFornecedor(id);
            return Ok();
        }

        [HttpPost("InserirFornecedor")]
        public IActionResult InserirFornecedor([FromBody] FornecedorInserirDTO dto)
        {
            _fornecedorRepository.InserirFornecedor(dto);
            return Ok();
        }

        [HttpPut("AtualizaFornecedor")]
        public IActionResult AtualizaFornecedor([FromBody] Fornecedor fornecedor)
        {
            _fornecedorRepository.AtualizarFornecedor(fornecedor);
            return Ok();
        }
    }
}
