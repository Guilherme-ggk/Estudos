using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Fevereiro
{
    class Conn
    {
        private const string Servidor = "localhost";
        private const string BancoDados = "livros";
        private const string Usuario = "root";
        private const string Senha = "0830755@Guilherme";

        static public string StrConn = $"server={Servidor};database={BancoDados};userid={Usuario};password={Senha}";
    }
}
