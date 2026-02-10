using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Fevereiro
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            Inicializar();
        }

        public void Inicializar()
        {
            dt = Livros.GetLivros(true);
            DgvLivros.DataSource = dt;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            using (var frm = new FmrCadastro())
            {
                frm.ShowDialog();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            using (var frm = new FmrCadastro())
            {
                frm.ShowDialog();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            using (var frm = new FmrCadastro())
            {
                frm.ShowDialog();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
