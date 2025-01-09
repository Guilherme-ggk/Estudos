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
            //LblResultado.Text = DateTime.Now.ToUniversalTime().ToString();
            //LblResultado.Text = DateTime.Now.ToShortTimeString();
            //LblResultado.Text = DateTime.Now.ToShortDateString().ToString();



            DateTime data = new DateTime(1985, 01, 24, 14, 35, 20);

            TimeSpan tempo = new TimeSpan(1, 0, 0);

           // LblResultado.Text = data.DayOfWeek.ToString();



            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnColors_Click(object sender, EventArgs e)
        {
            Color azul = Color.Blue;

            Color color1 = Color.FromName("Red");
            Color color2 = Color.FromKnownColor(KnownColor.AliceBlue);
            Color color3 = Color.FromArgb(255, 255, 255, 255);
            Color color4 = Color.FromArgb(100, Color.Black);



            this.BackColor = color1;

        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            //Font fonte = new Font("Arial", 15, FontStyle.Underline | FontStyle.Bold, GraphicsUnit.Pixel);

            Font fonte2 = new Font(FontFamily.GenericMonospace, 36,FontStyle.Regular,GraphicsUnit.Pixel);



            LblResultado.Text = "Guilherme Henrique Maximo dos Santos Almeida";

            LblResultado.Font = fonte2;
        }

        private void BtnApp_Click(object sender, EventArgs e)
        {
            /*Application.Exit();
           
            Application.Restart();

            
            string PATH = Application.StartupPath;*/
            string EXE = Application.ExecutablePath;

            LblResultado.Text = EXE;
        }

        private void BtnEnvironment_Click(object sender, EventArgs e)
        {
            Envir
        }
    }
}
