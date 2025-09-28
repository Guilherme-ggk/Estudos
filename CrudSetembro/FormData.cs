using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudSetembro
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
            Inicializar();
        }

        DataTable dt = new DataTable();

        public void Inicializar()
        {
            dt = Livros.GetLivros();
            DgvLivros.DataSource = dt;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            using (var frm = new FormCadastro(0))
            {
                frm.ShowDialog();
                DgvLivros.DataSource = Livros.GetLivros();
            }

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvLivros.Rows[DgvLivros.CurrentCell.RowIndex].Cells["id"].Value);
            using (var frm = new FormCadastro(id))
            {
                frm.ShowDialog();
              
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvLivros.Rows[DgvLivros.CurrentCell.RowIndex].Cells["id"].Value);
            using (var frm = new FormCadastro(id, true))
            {
                frm.ShowDialog();
               
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dt = Livros.GetLivros(TxtBuscar.Text);
            DgvLivros.DataSource = dt;
        }

        private void BtnApi1_Click(object sender, EventArgs e)
        {
            var resposta = GetApiData1();
        }


        public async Task GetApiData1()
        {
            var Url = "API";

            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage resposta = await cliente.GetAsync(Url))
                    {
                        if(resposta.IsSuccessStatusCode)
                        {
                            string conteudo = await resposta.Content.ReadAsStringAsync();
                            TxtApi1.Text = conteudo;
                        }
                        else
                        {
                            MessageBox.Show($"Erro de conexão: {resposta.StatusCode}");
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
}
