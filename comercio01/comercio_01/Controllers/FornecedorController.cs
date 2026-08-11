using comercio_01.DTO;
using comercio_01.Models;
using comercio_01.Repository;
using Microsoft.AspNetCore.Mvc;

namespace comercio_01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
        private readonly FornecedorRepository _fornecedorRepository;

        public FornecedorController(FornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        [HttpGet("BuscaFornecedor")]
        public IActionResult BuscaFornecedor()
        {
            List<Fornecedor> fornecedores = _fornecedorRepository.BuscaFornecedores();
            return Ok(fornecedores);
        }

        [HttpDelete("DeletaFornecedores")]
        public IActionResult DeletaFornecedores(int id)
        {
            _fornecedorRepository.DeletaFornecedor(id);
            return Ok();
        }

        [HttpPatch("AtualizaFornecedores")]
        public IActionResult AtualizaFornecedores(Fornecedor fornecedor)
        {
            _fornecedorRepository.AtualizaFornecedor(fornecedor);
            return Ok();
        }

        [HttpPost("CriaFornecedores")]
        public IActionResult CriaFornecedores(FornecedorInserirDTO dto)
        {
            _fornecedorRepository.CriaFornecedor(dto);
            return Ok();
        }
    }
}