using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_JANEIRO
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

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmCadastro(0))
            {
                frm.ShowDialog();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvLivros.Rows[DgvLivros.CurrentCell.RowIndex].Cells["id"].Value);
            using (var frm = new FrmCadastro(id))
            {
                frm.ShowDialog();
                DgvLivros.DataSource = Livros.GetLivros();
            }
        }

        private void BtnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dt = Livros.GetLivros(TxtBuscar.Text);
            DgvLivros.DataSource = dt;
        }
    }
}
