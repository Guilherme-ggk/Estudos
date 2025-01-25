using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudMenu
{
    static class Conn
    {
        private const string servidor = "localhost";
        private const string bancoDados = "livros";
        private const string usuario = "root";
        private const string senha = "@Guilherme30755";
    
        static public string strConn = $"server={servidor};database={bancoDados};userid={usuario};password={senha}";
    }
}
