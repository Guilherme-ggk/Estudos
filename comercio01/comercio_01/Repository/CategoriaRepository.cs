using comercio_01.DTO;
using comercio_01.Models;
using Dapper;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System.Data;

namespace comercio_01.Repository
{
    public class CategoriaRepository
    {
        public void CriaCategoria(CategoriaInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=farmacia;userid=root;password=0830755@Guilherme"))
            {
                connection.Open();

                connection.Execute("INSERT INTO categoria (nome) VALUES (@nome)", new
                {
                    nome = dto.Nome
                });
            }
        }

        public void DeletaCategoria(int id)
        {
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=farmacia;userid=root;password=0830755@Guilherme"))
            {
                connection.Open();

                connection.Execute("DELETE FROM categoria WHERE id=@id;", new
                {
                    id
                });
            }
        }

        public void AtualizaCategoria(Categoria categoria)
        {
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=farmacia;userid=root;password=0830755@Guilherme"))
            {
                connection.Open();

                connection.Execute("UPDATE categoria SET nome=@nome WHERE id=@id;", new
                {
                    id = categoria.Id,
                    nome = categoria.Nome
                });
            }
        }

        public List<Categoria> BuscaCategoria()
        {
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=farmacia;userid=root;password=0830755@Guilherme"))
            {
                connection.Open();

                List<Categoria> categorias = (List<Categoria>)connection.Query<Categoria>("SELECT * FROM categoria");

                return categorias;
            }
        }
    }
}