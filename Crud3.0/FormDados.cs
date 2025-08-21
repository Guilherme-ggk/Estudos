using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud3._0
{
    public partial class FormDados : Form
    {
        DataTable dt = new DataTable();
        public FormDados()
        {
            InitializeComponent();
            Inicializar();

        }

        public void Inicializar()
        {
            dt = Livros.GetLivros(true);
            DgvLivros.DataSource = dt;
        }

        private void DgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            using (var frm = new FormCadastro(0))
            {
                frm.ShowDialog();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvLivros.Rows[DgvLivros.CurrentCell.RowIndex].Cells["id"].Value);
            using (var frm = new FormCadastro(id))
            {
                frm.ShowDialog();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvLivros.Rows[DgvLivros.CurrentCell.RowIndex].Cells["id"].Value);
            using (var frm = new FormCadastro(id, true))
            {
                frm.ShowDialog();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
