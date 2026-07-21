using Microsoft.AspNetCore.Mvc;
using produtoDB.DTO;
using produtoDB.Models;
using produtoDB.Repository;

namespace produtoDB.Controllers
{
    [ApiController]
    [Route("ApiController")]
    public class FuncionarioController : ControllerBase
    {
        readonly private FuncionarioRepository _funcionarioRepository;

        public FuncionarioController(FuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [HttpDelete("DeletaFuncionario")]
        public ActionResult DeletaFuncionario([FromQuery]int id)
        {
            _funcionarioRepository.DeletarFuncionario(id);
            return Ok();
        }

        [HttpGet("ConsultaFuncionario")]
        public ActionResult ConsultaFuncionario()
        {
           List<Funcionario> funcionarios = _funcionarioRepository.ConsultarFuncionario();
            return Ok(funcionarios);
        }

        [HttpPut("AtualizarFuncionario")]
        public ActionResult AtualizarFuncionario([FromBody] Funcionario funcionario)
        {
            _funcionarioRepository.AtualizarFuncionario(funcionario);
            return Ok();
        }

        [HttpPost("InserirFuncionario")]
        public ActionResult InserirFuncionario([FromQuery] FuncionarioInserirDTO dto)
        {
            _funcionarioRepository.InserirFuncionario(dto);
            return Ok();
        }


    }
}
