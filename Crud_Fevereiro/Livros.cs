using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Fevereiro
{
     class Livros
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autores { get; set; }
        public decimal Unitario { get; set; }
        public int Saldo_inicial { get; set; }
        public int Estoque_minimo { get; set; }
        public char Ativo { get; set; }

        public static DataTable GetLivros(bool ativos)
        {
            var sql = "SELECT id, isbn, titulo, autores, unitario, saldo_inicial, estoque_minimo, ativo FROM livros";
            var dt = new DataTable();

            try
            {
                using (var cn = new MySqlConnection(Conn.StrConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }
    }
}
