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
            this.Text = "CLICADO";

            string res = "contem tipos";

            if(res.Contains("tipo"))
            {
                Console.WriteLine("Contém");
                label1.Text = "contem";
            }
            else
            {
                Console.WriteLine("Não contém");
                label1.Text = "nn contem";
            }
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
