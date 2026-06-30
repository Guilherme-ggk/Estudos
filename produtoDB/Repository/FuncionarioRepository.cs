using Dapper;
using MySql.Data.MySqlClient;
using produtoDB.DTO;
using produtoDB.Models;
using System.Data;

namespace produtoDB.Repository
{
    public class FuncionarioRepository
    {
        public void DeletarFuncionario(int id)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("DELETE FROM funcionario WHERE id=@id", new
                {
                    id
                });
            }
        }

        public void InserirFuncionario(FuncionarioInserirDTO dto)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("INSERT INTO funcionario (nome, cargo) VALUES (@nome, @cargo)", new
                {
                    nome = dto.Nome,
                    cargo = dto.Cargo
                });
            }
        }

        public void AtualizarFuncionario(Funcionario funcionario)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                connection.Execute("UPDATE funcionario SET nome=@nome, cargo=@cargo WHERE id=@id", new
                {
                    id = funcionario.Id,
                    nome = funcionario.Nome,
                    cargo = funcionario.Cargo
                });
            }
        }

        public List<Funcionario> ConsultarFuncionario()
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionDB.StrConn))
            {
                connection.Open();

                List<Funcionario> funcionarios = (List<Funcionario>)connection.Query<Funcionario>("SELECT * FROM funcionario");

                return funcionarios;
            }
        }
    }
}
