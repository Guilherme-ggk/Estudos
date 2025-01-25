using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudMenu
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            Inicializar();
            Configura();
        }
        private void Inicializar()
        {
            dt = Livros.GetLivros(true);
            dgvLivros.DataSource = dt;
        }
        private void Configura()
        {

            dgvLivros.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvLivros.RowHeadersWidth = 25;

            dgvLivros.Columns["id"].HeaderText = "ID";
            dgvLivros.Columns["id"].Visible = false;

            dgvLivros.Columns["isbn"].HeaderText = "ISBN";
            dgvLivros.Columns["isbn"].Width = 130;
            dgvLivros.Columns["isbn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLivros.Columns["isbn"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvLivros.Columns["titulo"].HeaderText = "TÍTULO";
            dgvLivros.Columns["titulo"].Width = 450;
            dgvLivros.Columns["titulo"].DefaultCellStyle.Padding = new Padding(5,0,0,0);
            dgvLivros.Columns["titulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLivros.Columns["titulo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvLivros.Columns["autores"].HeaderText = "AUTORES";
            dgvLivros.Columns["autores"].Width = 130;
            dgvLivros.Columns["autores"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLivros.Columns["autores"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvLivros.Columns["unitario"].DefaultCellStyle.Format = "n2";
            dgvLivros.Columns["unitario"].DefaultCellStyle.Padding = new Padding(0,0,5,0);
            dgvLivros.Columns["unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvLivros.Columns["saldo_inicial"].HeaderText = "SALDO";
            dgvLivros.Columns["saldo_inicial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvLivros.Columns["estoque_minimo"].HeaderText = "ESTOQUE";
            dgvLivros.Columns["estoque_minimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;




        }

    }
}
