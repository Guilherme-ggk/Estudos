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
      static public DataTable GetLivros(bool ativos)
      {
            var dt = new DataTable();

            var sql = "SELECT id, isbn, titulo, autores, unitario, saldo_inicial, estoque_minimo FROM livros.livros";

            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
      }
    }
}
