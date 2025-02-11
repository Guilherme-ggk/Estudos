using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FrmBanco : Form
    {
        DataTable dt = new DataTable();
        public FrmBanco()
        {
            InitializeComponent();
            Inicializar();
        }
        public void Inicializar()
        {
            dt = Livros.GetLivros(true);
            DgvLivros.DataSource = dt;
        }
        public void Config()
        {
            DgvLivros.Columns["id"].DefaultCellStyle.Font = new Font("Arial", 9);
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvLivros.Rows[DgvLivros.CurrentCell.RowIndex].Cells["id"].Value);
            using (FrmCadastroLivros fmr = new FrmCadastroLivros(id))
            {
                fmr.ShowDialog();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            using (FrmCadastroLivros fmr = new FrmCadastroLivros(0))
            {
                fmr.ShowDialog();
                DgvLivros.DataSource = Livros.GetLivros(true);
            }
        }
    }
}
