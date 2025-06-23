using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud3._0
{
    static class Conn
    {
        private const string Servidor = "localhost";
        private const string BancoDados = "livros";
        private const string usuario = "root";
        private const string Senha = "0830755@Guilherme";

        static public string StrConn = $"server={Servidor};database={BancoDados};user id={usuario};password={Senha}";
    }
}
