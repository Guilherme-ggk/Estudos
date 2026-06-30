using Dapper;
using MySql.Data.MySqlClient;
using produtoDB.DTO;
using produtoDB.Models;
using System.Data;

namespace produtoDB.Repository
{
    public class CategoriaRepository
    {
        public void InserirCategoria(CategoriaInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("INSERT INTO categoria (nome) VALUES (@nome)", new
                {
                    nome = dto.Nome
                });
            }
        }


        public void DeletarCategoria(int Id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("DELETE FROM categoria WHERE id=@id", new
                {
                    Id
                });
            }
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("UPDATE categoria SET nome=@nome WHERE id=@id", new
                {
                    id = categoria.Id,
                    nome = categoria.Nome
                });
            }
        }

        public List<Categoria> BuscaCategoria()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

               List<Categoria> categorias = (List<Categoria>)connection.Query<Categoria>("SELECT * FROM categoria");

                return categorias;
            }
        }
    }
}
