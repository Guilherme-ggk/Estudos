using comercio_01.DbConnection;
using comercio_01.DTO;
using comercio_01.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace comercio_01.Repository
{
    public class ProdutoRepository
    {
        public List<Produto> BuscaProdutos()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                List<Produto> Produtos = (List<Produto>)connection.Query<Produto>("SELECT * FROM Produto;");

                return Produtos;
            }
        }

        public void DeletaProduto(int id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                connection.Execute("DELETE FROM Produto WHERE id=@id;", new
                {
                    id
                });
            }
        }

        public void AtualizaProduto(Produto model)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                connection.Execute("UPDATE Produto (contato_id, fornecedor_id, nome, preco) SET (@contato_id, @fornecedor_id, @nome, @preco) WHERE id=@id;", new
                {
                    contato_id = model.Contato_Id,
                    fornecedor_id = model.Fornecedor_Id,
                    nome = model.Nome,
                    preco = model.Preco
                });
            }
        }

        public void CriaProduto(ProdutoInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                connection.Execute("INSERT INTO Produto (contato_id, fornecedor_id, nome, preco) VALUES (@contato_id, @fornecedor_id, @nome, @preco)", new
                {
                    contato_id = dto.Contato_Id,
                    fornecedor_id = dto.Fornecedor_Id,
                    nome = dto.Nome,
                    preco = dto.Preco
                });
            }
        }
    }
}