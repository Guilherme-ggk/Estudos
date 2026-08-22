using comercio_01.DbConnection;
using comercio_01.DTO;
using comercio_01.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace comercio_01.Repository
{
    public class Item_VendaRepository
    {
        public List<Item_Venda> BuscaItem_Vendas()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                List<Item_Venda> Item_Vendas = (List<Item_Venda>)connection.Query<Item_Venda>("SELECT * FROM Item_Venda;");

                return Item_Vendas;
            }
        }

        public void DeletaItem_Venda(int id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                connection.Execute("DELETE FROM Item_Venda WHERE id=@id;", new
                {
                    id
                });
            }
        }

        public void AtualizaItem_Venda(Item_Venda model)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                connection.Execute("UPDATE Item_Venda (quantidade, preco_unitario, produto_id, venda_id) SET (@quantidade, @preco_unitario, @produto_id, @venda_id) WHERE id=@id;", new
                {

                    id = model.Id,
                    quantidade = model.Quantidade,
                    preco_unitario = model.Preco_unitario,
                    produto_id = model.Produto_Id,
                    venda_id = model.Venda_Id
                });
            }
        }

        public void CriaItem_Venda(Item_VendaInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conn))
            {
                connection.Open();

                connection.Execute("INSERT INTO Item_Venda (quantidade, preco_unitario, produto_id, venda_id) VALUES (@quantidade, @preco_unitario, @produto_id, @venda_id)", new
                {
                    quantidade = dto.Quantidade,
                    preco_unitario = dto.Preco_unitario,
                    produto_id = dto.Produto_Id,
                    venda_id = dto.Venda_Id
                });
            }
        }
    }
}