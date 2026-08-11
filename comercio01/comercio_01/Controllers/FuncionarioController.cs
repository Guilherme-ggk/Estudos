using comercio_01.DTO;
using comercio_01.Models;
using comercio_01.Repository;
using Microsoft.AspNetCore.Mvc;

namespace comercio_01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly FuncionarioRepository _FuncionarioRepository;

        public FuncionarioController(FuncionarioRepository FuncionarioRepository)
        {
            _FuncionarioRepository = FuncionarioRepository;
        }

        [HttpGet("BuscaFuncionario")]
        public IActionResult BuscaFuncionario()
        {
            List<Funcionario> Funcionarios = _FuncionarioRepository.BuscaFuncionarios();
            return Ok(Funcionarios);
        }

        [HttpDelete("DeletaFuncionarios")]
        public IActionResult DeletaFuncionarios(int id)
        {
            _FuncionarioRepository.DeletaFuncionario(id);
            return Ok();
        }

        [HttpPatch("AtualizaFuncionarios")]
        public IActionResult AtualizaFuncionarios(Funcionario Funcionario)
        {
            _FuncionarioRepository.AtualizaFuncionario(Funcionario);
            return Ok();
        }

        [HttpPost("CriaFuncionarios")]
        public IActionResult CriaFuncionarios(FuncionarioInserirDTO dto)
        {
            _FuncionarioRepository.CriaFuncionario(dto);
            return Ok();
        }
    }
}