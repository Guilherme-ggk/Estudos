using comercio_01.DbConnection;
using comercio_01.DTO;
using comercio_01.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace comercio_01.Repository
{
    public class ClienteRepository
    {
        public List<Cliente> BuscaClientes()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
            {
                connection.Open();

                List<Cliente> Clientes = (List<Cliente>)connection.Query<Cliente>("SELECT * FROM Cliente;");

                return Clientes;
            }
        }

        public void DeletaCliente(int id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
            {
                connection.Open();

                connection.Execute("DELETE FROM Cliente WHERE id=@id;", new
                {
                    id
                });
            }
        }

        public void AtualizaCliente(Cliente model)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
            {
                connection.Open();

                connection.Execute("UPDATE Cliente (nome, cpf, telefone) SET (@nome, @cpf, @telefone) WHERE id=@id;", new
                {
                    id = model.Id,
                    nome = model.Nome,
                    cpf = model.Cpf,
                    telefone = model.Telefone
                });
            }
        }

        public void CriaCliente(ClienteInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
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
    }
}