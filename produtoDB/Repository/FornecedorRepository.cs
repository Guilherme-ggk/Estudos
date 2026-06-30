using Dapper;
using MySql.Data.MySqlClient;
using produtoDB.DTO;
using produtoDB.Models;
using System.Data;

namespace produtoDB.Repository
{
    public class FornecedorRepository
    {
        public List<Fornecedor> ConsultaFornecedores()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                List<Fornecedor> fornecedores = (List<Fornecedor>)connection.Query<Fornecedor>("SELECT * FROM fornecedor");

                return fornecedores;
            }
        }


        public void InserirFornecedor(FornecedorInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("INSERT INTO fornecedor (nome, contato) VALUES (@nome, @contato)", new
                {
                    nome = dto.Nome,
                    contato = dto.Contato
                });
            }
        }

        public void DeletarFornecedor(int id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("DELETE FROM fornecedor WHERE id=@id", new
                {
                    id
                });
            }
        }

        public void AtualizarFornecedor(Fornecedor fornecedor)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("UPDATE fornecedor  SET nome=@nome, contato=@contato WHERE id=@id", new
                {
                    id = fornecedor.Id,
                    nome = fornecedor.Nome,
                    contato = fornecedor.Contato
                });
            }
        }
    }
}
