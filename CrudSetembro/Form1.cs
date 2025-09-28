using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
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





        private void BtnApi_Click(object sender, EventArgs e)
        {
            var respostaApi = GetApi();
        }

        public async Task GetApi()
        {
            var url = "https://api.adviceslip.com/advice";

            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage resposta = await cliente.GetAsync(url))
                    {
                        if(resposta.IsSuccessStatusCode)
                        {
                            string conteudo = await resposta.Content.ReadAsStringAsync();
                            TxtApi1.Text = conteudo;
                        }
                        else
                        {
                            MessageBox.Show($"Erro de conexão {resposta.StatusCode}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void BtnApi2_Click(object sender, EventArgs e)
        {
            var resposta = GetApi2();
        }


        public async Task GetApi2()
        {
            var url = "https://api.kanye.rest";

            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage resposta = await cliente.GetAsync(url))
                    {
                        if(resposta.IsSuccessStatusCode)
                        {
                            string conteudo = await resposta.Content.ReadAsStringAsync();
                            TxtApi2.Text = conteudo;
                        }
                        else
                        {
                            MessageBox.Show($"Erro de conexão {resposta.StatusCode}");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }




        private void BtnApi3_Click(object sender, EventArgs e)
        {
            var resposta = GetApi3();
        }


        public async Task GetApi3()
        {
            var url = "https://api.kanye.rest";

            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage resposta = await cliente.GetAsync(url))
                    {
                        if (resposta.IsSuccessStatusCode)
                        {
                            string conteudo = await resposta.Content.ReadAsStringAsync();
                            TxtApi3.Text = conteudo;
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

        private void BtnApi4_Click(object sender, EventArgs e)
        {
            var resposta = GetApi4();
        }

        public async Task GetApi4()
        {
            var url = "https://dummyjson.com/user/2";

            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage resposta = await cliente.GetAsync(url))
                    {
                        if(resposta.IsSuccessStatusCode)
                        {
                            string conteudo = await resposta.Content.ReadAsStringAsync();
                            TxtApi4.Text = conteudo;
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

        private async void BtnApi5_Click(object sender, EventArgs e)
        {
            var url = "https://dummyjson.com/users/2";

            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    HttpResponseMessage resposta = await cliente.GetAsync(url);

                    if (resposta.IsSuccessStatusCode)
                    {
                        string conteudo = await resposta.Content.ReadAsStringAsync();
                        TxtApi5.Text = conteudo;
                    }
                    else
                    {
                        MessageBox.Show($"Erro de conexão {resposta.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private async void BtnApi6_Click(object sender, EventArgs e)
        {
            var url = "https://dummyjson.com/users/2";


            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage resposta = await cliente.GetAsync(url))
                    {
                        if(resposta.IsSuccessStatusCode)
                        {
                            string conteudo = await resposta.Content.ReadAsStringAsync();
                            TxtApi6.Text = conteudo;
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

        private async void BtnApi7_Click(object sender, EventArgs e)
        {
            var url = "https://dummyjson.com/users/";
            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage resposta = await cliente.GetAsync(url))
                    {
                        if (resposta.IsSuccessStatusCode)
                        {
                            string conteudo = await resposta.Content.ReadAsStringAsync();
                            TxtApi7.Text = conteudo;    
                        }
                        else
                        {
                            MessageBox.Show($"erro de conexão: {resposta.StatusCode}");
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
