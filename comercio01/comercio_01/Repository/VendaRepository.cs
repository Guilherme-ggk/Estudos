using comercio_01.DbConnection;
using comercio_01.DTO;
using comercio_01.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace comercio_01.Repository
{
    public class VendaRepository
    {
        public List<Venda> BuscaVendas()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
            {
                connection.Open();

                List<Venda> Vendas = (List<Venda>)connection.Query<Venda>("SELECT * FROM Venda;");

                return Vendas;
            }
        }

        public void DeletaVenda(int id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
            {
                connection.Open();

                connection.Execute("DELETE FROM Venda WHERE id=@id;", new
                {
                    id
                });
            }
        }

        public void AtualizaVenda(Venda model)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
            {
                connection.Open();

                connection.Execute("UPDATE Venda SET (data_hora=@data_hora, cliente_id=@cliente_id, funcionario_id=@funcionario_id) WHERE id=@id;", new
                {
                    id = model.Id,
                    data_hora = model.Data_hora,
                    funcionario_id = model.Funcionario_Id,
                    cliente_id = model.Cliente_Id
                });
            }
        }

        public void CriaVenda(VendaInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.conexao))
            {
                connection.Open();

                connection.Execute("INSERT INTO Venda ( data_hora, funcionario_id, cliente_id) VALUES (@data_hora, @funcionario_id, @cliente_id)", new
                {
                    data_hora = dto.Data_hora,
                    funcionario_id = dto.Funcionario_Id,
                    cliente_id = dto.Cliente_Id
    });
            }
        }
    }
}