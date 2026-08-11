using comercio_01.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace comercio_01.DTO
{
    public class FornecedorInserirDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string Contato { get; set; } = string.Empty;
    }
}