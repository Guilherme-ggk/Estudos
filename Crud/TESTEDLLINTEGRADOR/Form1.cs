using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Integrador.Class1;

namespace TESTEDLLINTEGRADOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtToken_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGerarToken_Click(object sender, EventArgs e)
        {
            try
            {
                BB objBB = new BB(); // Instancia a classe da DLL
                string clientId = ""; // Substituir pelo ID correto
                string token = objBB.GerarTokenBB(clientId);

                TxtToken.Text = token; // Exibe o token no TextBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar token: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
