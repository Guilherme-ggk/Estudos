using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    static class Conn
    {
        private const string servidor = "localhost";
        private const string bancoDados = "livros";
        private const string usuario = "root";
        private const string senha = "@Guilherme30755";

        public static string StrConn = $"server={servidor}, database={bancoDados}, User id={usuario}; password={senha}";
    }
}
