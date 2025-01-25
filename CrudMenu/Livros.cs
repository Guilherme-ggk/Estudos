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
    class Livros
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autores { get; set; }
        public decimal Unitario { get; set; }
        public int Estoque_minimo { get; set; }
        public int Saldo_inicial { get; set; }
        public DateTime Data_saldo_inicial { get; set; }
        public int Saldo_atual { get; set; }
        public Char Ativo { get; set; }

        public static DataTable GetLivros( bool ativos )
        {
            var dt = new DataTable();

            var sql = "SELECT id, isbn, titulo FROM livros.livros";

            try
            {
                using (var cn = new MySqlConnection(Conn.strCon))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }

                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message );
            }
            return dt;
        }
    }
}
