using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudandoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "Guilherme";

            int tamanho = nome.Length;


            label1.Text = $"{tamanho}";


            /*string nome = "Guilherme Henrique";

            string res = nome.Insert(10 , " A ");

            string res2 = nome.Replace("Guilherme", "Giovana");

            label1.Text = res2;*/


            /*string res = "Guilherme Henrique";

           int indice = res.IndexOf('u');
            int indice2 = res.LastIndexOf('u');

            label1.Text = "indice" + indice2;*/




            /* this.Text = "CLICADO";

             int res = 5400;
             bool res2 = false;

             string resultado = res.ToString();
             string resultado2 = res2.ToString();

             label1.Text = resultado2;

             /*if(res.Contains("z"))
             {
                 Console.WriteLine("Contém");
                 label1.Text = "contem";
             }
             else
             {
                 Console.WriteLine("Não contém");
                 label1.Text = "nn contem";
             }*/
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "mudando";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "saiu";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Text = "entrou";
        }
    }
}
