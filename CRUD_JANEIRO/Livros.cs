using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_JANEIRO
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

        public static DataTable GetLivros(bool Livro_Ativo)
        {
            var dt = new DataTable();
            var sql = "SELECT id, isbn, titulo, autores, unitario, saldo_inicial, estoque_minimo, ativo FROM livros";

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        public void GetLivro(int id)
        {
            var sql = "SELECT * FROM livros WHERE id =" + id;

            try
            {
                using (var cn = new MySqlConnection(Conn.StrConn))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql,cn))
                    {
                        using(var dr = cmd.ExecuteReader())
                        {
                            if(dr.HasRows)
                            {
                                if(dr.Read())
                                {
                                    this.Id = Convert.ToInt32(dr["id"]);
                                    this.Isbn = dr["isbn"].ToString();
                                    this.Titulo = dr["titulo"].ToString();
                                    this.Autores = dr["autores"].ToString();
                                    this.Unitario = Convert.ToDecimal(dr["unitario"]);
                                    this.Saldo_inicial = Convert.ToInt32(dr["saldo_inicial"]);
                                    this.Estoque_minimo = Convert.ToInt32(dr["estoque_minimo"]);
                                    this.Ativo = Convert.ToChar(dr["ativo"]);
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
