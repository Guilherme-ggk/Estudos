using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudGelt
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
            Inicializar();
        }

        DataTable dt = new DataTable();

        public void Inicializar()
        {
            dt = Livros.GetLivros();
            DgvLivros.DataSource = dt;
        }



        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            using (var frm = new FormCadastro(0))
            {
                frm.ShowDialog();
                DgvLivros.DataSource = Livros.GetLivros();
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

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
            dt = Livros.GetLivros(TxtBuscar.Text);
            DgvLivros.DataSource= dt;
        }


    }
}
