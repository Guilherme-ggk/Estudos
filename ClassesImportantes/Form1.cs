using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Word!");
            MessageBox.Show("Olá meus amigos!", "Titulo da mensagem");

            DialogResult res = MessageBox.Show("teste", "titulo da mensagem", MessageBoxButtons.OKCancel);

            if(res == DialogResult.OK)
            {
                LblResultado.Text = "Clicou em OK";
            }
            else if(res == DialogResult.Cancel)
            {
                LblResultado.Text = "Clicou em CANCELAR";
            }

            MessageBox.Show("Deseja sair?", "Titulo da Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
        private void BtnAleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random();
          
            double valor2 = r.NextDouble();
            int valor = r.Next();
            

            LblResultado.Text = valor2.ToString();
        }

        private void BtnTimeSpan_Click(object sender, EventArgs e)
        {
           // LblResultado.Text = TimeSpan.FromMinutes(90).ToString();


            TimeSpan inicio = new TimeSpan(1, 0, 0);

            TimeSpan fim = new TimeSpan(5, 0, 0);

            TimeSpan resultado = fim - inicio;

            LblResultado.Text = resultado.Hours.ToString();
        }

        private void BtnDateTime_Click(object sender, EventArgs e)
        {
            //LblResultado.Text = DateTime.Now.ToString();
            //LblResultado.Text = DateTime.Today.ToString();
            //LblResultado.Text = DateTime.DaysInMonth(2022 ,08).ToString();
            //LblResultado.Text = DateTime.IsLeapYear(2016).ToString();
            LblResultado.Text = DateTime.Now.ToUniversalTime().ToString();

        }
    }
}
