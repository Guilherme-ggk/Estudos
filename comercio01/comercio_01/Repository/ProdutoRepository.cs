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
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
            {
                connection.Open();

                List<Produto> Produtos = (List<Produto>)connection.Query<Produto>("SELECT * FROM Produto;");

                return Produtos;
            }
        }

        public void DeletaProduto(int id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
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
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
            {
                connection.Open();

                connection.Execute("UPDATE Produto (categoria_id, fornecedor_id, nome, descricao, preco, estoque) SET (@categoria_id, @fornecedor_id, @nome, @descricao, @preco, @estoque) WHERE id=@id;", new
                {
                    categoria_id = model.Categoria_Id,
                    fornecedor_id = model.Fornecedor_Id,
                    nome = model.Nome,
                    descricao = model.Descricao,
                    preco = model.Preco,
                    estoque = model.Estoque
                });
            }
        }

        public void CriaProduto(ProdutoInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
            {
                connection.Open();

                connection.Execute("INSERT INTO Produto (categoria_id, fornecedor_id, nome, descricao, preco, estoque) VALUES (@categoria_id, @fornecedor_id, @nome, @descricao, @preco, @estoque)", new
                {
                    categoria_id = dto.Categoria_Id,
                    fornecedor_id = dto.Fornecedor_Id,
                    nome = dto.Nome,
                    descricao = dto.Descricao,
                    preco = dto.Preco,
                    estoque = dto.Estoque
                });
            }
        }
    }
}