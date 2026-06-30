using Dapper;
using MySql.Data.MySqlClient;
using produtoDB.DTO;
using produtoDB.Models;
using System.Data;

namespace produtoDB.Repository
{
    public class Item_VendaRepository
    {
        public void DeletarItem_Venda(int id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("DELETE FROM item_venda WHERE id=@id", new
                {
                    id
                });
            }
        }

        public void InserirItem_Venda(Item_VendaInserirDTO item_venda)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("INSERT INTO item_venda (quantidade, preco_unitario, produto_id, venda_id) VALUES (@quantidade, @preco_unitario, @produto_id, @venda_id)", new
                {
                    quantidade = item_venda.Quantidade,
                    preco_unitario = item_venda.Preco_unitario,
                    produto_id = item_venda.Produto_id,
                    venda_id = item_venda.Venda_id
                });
            }
        }

        public void AtualizarItem_Venda(Item_Venda item_venda)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("UPDATE item_venda SET quantidade=@quantidade, preco_unitario=@preco_unitario, produto_id=@produto_id, venda_id=@venda_id WHERE id=@id", new
                {
                    id = item_venda.Id,
                    quantidade = item_venda.Quantidade,
                    preco_unitario = item_venda.Preco_unitario,
                    produto_id = item_venda.Produto_id,
                    venda_id = item_venda.Venda_id

                });
            }
        }

        public List<Item_Venda> ConsultarItem_Venda()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                List<Item_Venda> item_vendas = (List<Item_Venda>)connection.Query<Item_Venda>("SELECT * FROM item_venda");

                return item_vendas;
            }
        }
    }
}
