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
    }
}
