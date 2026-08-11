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
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=comercio;userid=root;password=0830755@Guilherme;"))
            {
                connection.Open();

                List<Venda> Vendas = (List<Venda>)connection.Query<Venda>("SELECT * FROM Venda;");

                return Vendas;
            }
        }

        public void DeletaVenda(int id)
        {
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=comercio;userid=root;password=0830755@Guilherme;"))
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
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=comercio;userid=root;password=0830755@Guilherme;"))
            {
                connection.Open();

                connection.Execute("UPDATE Venda (contato_id, fornecedor_id, nome, preco) SET (@contato_id, @fornecedor_id, @nome, @preco) WHERE id=@id;", new
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
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=comercio;userid=root;password=0830755@Guilherme;"))
            {
                connection.Open();

                connection.Execute("INSERT INTO Venda (contato_id, fornecedor_id, nome, preco) VALUES (@contato_id, @fornecedor_id, @nome, @preco)", new
                {
                    data_hora = dto.Data_hora,
                    funcionario_id = dto.Funcionario_Id,
                    cliente_id = dto.Cliente_Id
                });
            }
        }
    }
}