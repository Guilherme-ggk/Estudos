using comercio_01.DTO;
using comercio_01.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace comercio_01.Repository
{
    public class FuncionarioRepository
    {
        public List<Funcionario> BuscaFuncionarios()
        {
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=comercio;userid=root;password=0830755@Guilherme;"))
            {
                connection.Open();

                List<Funcionario> Funcionarios = (List<Funcionario>)connection.Query<Funcionario>("SELECT * FROM Funcionario;");

                return Funcionarios;
            }
        }

        public void DeletaFuncionario(int id)
        {
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=comercio;userid=root;password=0830755@Guilherme;"))
            {
                connection.Open();

                connection.Execute("DELETE FROM Funcionario WHERE id=@id;", new
                {
                    id
                });
            }
        }

        public void AtualizaFuncionario(Funcionario model)
        {
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=comercio;userid=root;password=0830755@Guilherme;"))
            {
                connection.Open();

                connection.Execute("UPDATE Funcionario (nome, cargo) SET (@nome, @cargo) WHERE id=@id;", new
                {
                    id = model.Id,
                    nome = model.Nome,
                    cargo = model.Cargo
                });
            }
        }

        public void CriaFuncionario(FuncionarioInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection("server=localhost;database=comercio;userid=root;password=0830755@Guilherme;"))
            {
                connection.Open();

                connection.Execute("INSERT INTO Funcionario (nome, contato) VALUES (@nome, @contato)", new
                {
                    nome = dto.Nome,
                    cargo = dto.Cargo
                });
            }
        }
    }
}