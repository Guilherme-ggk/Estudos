using comercio_01.DbConnection;
using comercio_01.DTO;
using comercio_01.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace comercio_01.Repository
{
    public class FornecedorRepository
    {
        public List<Fornecedor> BuscaFornecedores()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                List<Fornecedor> fornecedores = (List<Fornecedor>)connection.Query<Fornecedor>("SELECT * FROM fornecedor;");

                return fornecedores;
            }
        }

        public void DeletaFornecedor(int id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                connection.Execute("DELETE FROM fornecedor WHERE id=@id;", new
                {
                    id
                });
            }
        }

        public void AtualizaFornecedor(Fornecedor model)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                connection.Execute("UPDATE fornecedor (nome, contato) SET (@nome, @contato) WHERE id=@id;", new
                {
                    id = model.Id,
                    nome = model.Nome,
                    contato = model.Contato
                });
            }
        }

        public void CriaFornecedor(FornecedorInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                connection.Execute("INSERT INTO fornecedor (nome, contato) VALUES (@nome, @contato)", new
                {
                    nome = dto.Nome,
                    contato = dto.Contato
                });
            }
        }
    }
}