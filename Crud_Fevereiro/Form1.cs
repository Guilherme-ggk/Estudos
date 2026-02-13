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
            dt = Livros.GetLivros();
            DgvLivros.DataSource = dt;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            using (var frm = new FmrCadastro(0))
            {
                frm.ShowDialog();
                DgvLivros.DataSource = dt;
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvLivros.Rows[DgvLivros.CurrentCell.RowIndex].Cells["id"].Value);
            using (var frm = new FmrCadastro(id))
            {
                frm.ShowDialog();
                DgvLivros.DataSource = dt;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvLivros.Rows[DgvLivros.CurrentCell.RowIndex].Cells["id"].Value);
            using (var frm = new FmrCadastro(id, true))
            {
                frm.ShowDialog();
                DgvLivros.DataSource = dt;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dt = Livros.GetLivros(TxtBuscar.Text);
            DgvLivros.DataSource = dt;
        }
    }
}
