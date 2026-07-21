using Microsoft.AspNetCore.Mvc;
using produtoDB.DTO;
using produtoDB.Models;
using produtoDB.Repository;

namespace produtoDB.Controllers
{
    [ApiController]
    [Route("ApiController")]
    public class ClienteController : ControllerBase
    {
        readonly private ClienteRepository _clienteRepository;

        public ClienteController (ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet("ConsultaCliente")]
        public IActionResult ConsultaCliente()
        {
            List<Cliente> clientes = _clienteRepository.BuscaCliente();
            return Ok(clientes);
        }


        [HttpDelete("DeletaCliente")]
        public IActionResult DeletaCliente([FromQuery] int id)
        {
            _clienteRepository.DeletarCliente(id);
            return Ok(id);
        }

        [HttpPost("InserirCliente")]
        public IActionResult InserirCliente([FromBody] ClienteInserirDTO dto)
        {
            _clienteRepository.InserirCliente(dto);
            return Ok();
        }

        [HttpPut("AtualizarCliente")]
        public IActionResult AtualizarCliente([FromBody] Cliente cliente)
        {
            _clienteRepository.AtualizarCliente(cliente);
            return Ok();
        }
    }
}
