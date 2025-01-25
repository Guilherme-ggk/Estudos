using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudMenu
{
    static class Conn
    {
        private const string servidor = "localhost";
        private const string bancoDados = "livros";
        private const string usuario = "root";
        private const string senha = "@Guilherme30755";

        static public string strCon = $"server={servidor};database={bancoDados};user id ={usuario};password={senha}";
    }
}
