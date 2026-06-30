using Dapper;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using produtoDB.DTO;
using produtoDB.Models;
using System.Data;

namespace produtoDB.Repository
{
    public class ClienteRepository
    {
        public void InserirCliente(ClienteInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("INSERT INTO Cliente (nome, cpf, telefone) VALUES (@nome, @cpf, @telefone)", new
                {
                    nome = dto.Nome,
                    cpf = dto.Cpf,
                    telefone = dto.Telefone
                });
            }
        }


        public void DeletarCliente(int Id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("DELETE FROM cliente WHERE id=@id", new
                {
                    Id
                });
            }
        }

        public void AtualizarCliente(Cliente cliente)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("UPDATE cliente SET nome=@nome, cpf=@cpf, telefone=@telefone WHERE id=@id", new
                {
                    id = cliente.Id,
                    nome = cliente.Nome,
                    cpf = cliente.Cpf,
                    telefone = cliente.Telefone
                });
            }
        }

        public List<Cliente> BuscaCliente()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                List<Cliente> clientes = (List<Cliente>)connection.Query<Cliente>("SELECT * FROM cliente");

                return clientes;
            }
        }
    }
}
