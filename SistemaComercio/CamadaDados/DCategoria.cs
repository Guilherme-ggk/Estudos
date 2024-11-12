using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    internal class DCategoria
    {
        private int _Idcategoria;
        private string _Nome;
        private string _Descricao;
        private string _Textobuscar;

        public int Idcategoria { get => _Idcategoria; set => _Idcategoria = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }


        //Construtor Vazio

        public DCategoria()
        {

        }

        // Construtor com Paramêtros

        public DCategoria(int idcategoria, string nome, string descricao, string textobuscar)
        {
            this.Idcategoria = idcategoria;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Textobuscar = textobuscar;
        }



        //INSERIR

        public string Inserir(DCategoria Categoria)
        {
            string resposta;
            SqlConnection SQLCON = new SqlConnection();
            try
            {
                SQLCON.ConnectionString = Conexao.Cn;

                SqlCommand SQLcmd = new SqlCommand();
                SQLcmd.Connection = SQLCON;
                SQLcmd.CommandText = "";
            }
            catch (Exception ex)
            {
                resposta = ex.Message;
            }

            finally 
            {
                if(SQLCON.State ==ConnectionState.Open)
                {
                    SQLCON.Close();
                }
            }
        }
        //EDITAR

        public string Editar(DCategoria Categoria)
        {

        }
        //EXCLUIR

        public string Excluir(DCategoria Categoria)
        {

        }
        //MOSTRAR

        public DataTable Mostrar(DCategoria Categoria)
        {

        }
        //MÉTODO BUSCAR NOME

        public string BuscarNome(DCategoria Categoria)
        {

        }
    }
}
