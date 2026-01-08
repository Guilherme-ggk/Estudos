using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_JANEIRO
{
    static class Conn // static, para evitar que seja instanciada
    {
        // const nunca muda


        private const string Servidor = "localhost";
        private const string BancoDados = "livros";
        private const string Usuario = "root";
        private const string Senha = "0830755@Guilherme";

        static public string StrConn = $" server={Servidor}; database={BancoDados}; userid={Usuario}; password={Senha}"; //string de conexão

    }
}
