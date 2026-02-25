using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    class hardware
    {
        public int id { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }
        public int estoque { get; set; }
        public DateTime data_cadastro { get; set; }


        public static DataTable GetHardware(bool ativo)
        {
            var dt = new DataTable();
            var sql = "SELECT id, nome, preco, estoque, data_cadastro FROM hardware.processador";

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
