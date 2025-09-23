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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form FrmAtivo;

        public void FormShow(Form Frm)
        {
            FormClose();
            FrmAtivo = Frm;
            Frm.TopLevel = false;
            PanelForm.Controls.Add(Frm);
            Frm.BringToFront();
            Frm.Show();
        }

        public void FormClose()
        {
            if(FrmAtivo != null)
                FrmAtivo.Close();
        }

        public void ButtonActive(Button FrmAtivo)
        {
            foreach(Control Ctrl in PanelPrincipal.Controls)
                Ctrl.ForeColor = Color.Black;

            FrmAtivo.ForeColor = Color.Blue;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnData);
            FormClose();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnData);
            FormShow(new FormData());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

      


        public async Task API()
        {
            var url = "https://api.chucknorris.io/jokes/random";

            using (HttpClient http = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await http.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string conteudo = await response.Content.ReadAsStringAsync();
                        TxtApi.Text = conteudo;
                    }
                    else
                    {
                        MessageBox.Show($"ERRO: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERRO DE CONEXÃO {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resposta = API();
        }




        public async Task api1()
        {
            var url = "URL";

            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    HttpResponseMessage mensagem = await cliente.GetAsync(url);

                    if(mensagem.IsSuccessStatusCode)
                    {
                        string conteudo = await mensagem.Content.ReadAsStringAsync();
                        TxtApi.Text= conteudo;
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
