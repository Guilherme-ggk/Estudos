using Dapper;
using MySql.Data.MySqlClient;
using produtoDB.DTO;
using produtoDB.Models;
using System.Data;

namespace produtoDB.Repository
{

    public class VendaRepository
    {
        public void InserirVenda(VendaInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("INSERT INTO venda (data_hora, funcionario_id, cliente_id) VALUES (@data_hora, @funcionario_id, @cliente_id)", new
                {
                   data_hora = dto.Data_hora,
                   funcionario_id = dto.Funcionario_id,
                   cliente_id = dto.Cliente_id
                });
            }
        }


        public void DeletarVenda(int Id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("DELETE FROM venda WHERE id=@id", new
                {
                    Id
                });
            }
        }

        public void AtualizarVenda(Venda venda)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("UPDATE venda SET data_hora=@data_hora, funcionario_id=@funcionario_id, cliente_id=@cliente_id WHERE id=@id", new
                {
                    id = venda.Id,
                    data_hora = venda.Data_hora,
                    funcionario_id = venda.Funcionario_id,
                    cliente_id = venda.Cliente_id
                });
            }
        }

        public List<Venda> BuscaVenda()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                List<Venda> vendas = (List<Venda>)connection.Query<Venda>("SELECT * FROM venda");

                return vendas;
            }
        }

    }
}

