using comercio_01.DTO;
using comercio_01.Models;
using comercio_01.Repository;
using Microsoft.AspNetCore.Mvc;

namespace comercio_01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository _ClienteRepository;

        public ClienteController(ClienteRepository ClienteRepository)
        {
            _ClienteRepository = ClienteRepository;
        }

        [HttpGet("BuscaCliente")]
        public IActionResult BuscaCliente()
        {
            List<Cliente> Clientes = _ClienteRepository.BuscaClientes();
            return Ok(Clientes);
        }

        [HttpDelete("DeletaClientes")]
        public IActionResult DeletaClientes(int id)
        {
            _ClienteRepository.DeletaCliente(id);
            return Ok();
        }

        [HttpPatch("AtualizaClientes")]
        public IActionResult AtualizaClientes(Cliente Cliente)
        {
            _ClienteRepository.AtualizaCliente(Cliente);
            return Ok();
        }

        [HttpPost("CriaClientes")]
        public IActionResult CriaClientes(ClienteInserirDTO dto)
        {
            _ClienteRepository.CriaCliente(dto);
            return Ok();
        }
    }
}