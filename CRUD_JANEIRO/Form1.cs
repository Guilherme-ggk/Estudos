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
        DataTable dt = new DataTable(); // referenciando

        public Form1()
        {
            InitializeComponent();
            inicializar(); // colocando a função para ser chamada
        }

        private void  inicializar() // função que inicia o banco de dados no DataGridView
        {
            dt = Livro.GetLivros(false);
            DgvLivros.DataSource = dt;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvLivros.Rows[DgvLivros.CurrentCell.RowIndex].Cells["id"].Value);

            using (var frm = new FrmCadastroLivros(id))
            {
                frm.ShowDialog();
            }
        }
    }
}
