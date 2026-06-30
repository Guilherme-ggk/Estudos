using Dapper;
using MySql.Data.MySqlClient;
using produtoDB.DTO;
using produtoDB.Models;
using System.Data;

namespace produtoDB.Repository
{
    public class ProdutoRepository
    {
        public List<Produto> ConsultaProduto()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                List<Produto> produtos = (List<Produto>)connection.Query<Produto>("SELECT * FROM produto");

                return produtos;
            }
        }

        public void DeleteProduto(int id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("DELETE FROM produto WHERE id=@id", new
                {
                    id
                });
            }
        }

        public void InserirProduto(ProdutoInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("INSERT INTO produto (categoria_id, fornecedor_id, nome, preco) VALUES (@categoria_id, @fornecedor_id, @nome, @preco)", new
                {
                    categoria_id = dto.Categoria_id,
                    fornecedor_id = dto.Fornecedor_id,
                    nome = dto.Nome,
                    preco = dto.preco
                });
            }
        }

        public void AtualizarProduto(Produto produto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("UPDATE produto SET categoria_id=@categoria_id, fornecedor_id=@fornecedor_id, nome=@nome, preco=@preco", new
                {
                    id = produto.Id,
                    categoria_id = produto.Categoria_id,
                    fornecedor_id = produto.Fornecedor_id,
                    nome = produto.Nome,
                    preco = produto.preco
                });
            }
        }
    }
}
