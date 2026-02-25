using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    static class Conn
    {
        private const string Servidor = "localhost";
        private const string BancoDados = "hardware";
        private const string Usuario = "root";
        private const string Senha = "0830755@Guilherme";

        static public string StrConn = $"server={Servidor};database={BancoDados};userid={Usuario};password={Senha}";
    }
}
