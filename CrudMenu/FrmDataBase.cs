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
    public partial class FrmDataBase : Form
    {
        DataTable dt = new DataTable();


        public FrmDataBase()
        {
            InitializeComponent();
            Inicia();
            Config();

        }

        private void FrmDataBase_Load(object sender, EventArgs e)
        {
            
        }
        private void Inicia()
        {
            dt = Livros.GetLivros(true);
            dvgLivros.DataSource = dt;
        }
        private void Config()
        {
            dvgLivros.DefaultCellStyle.Font = new Font("Arial", 9);
            dvgLivros.RowHeadersWidth = 25;

            dvgLivros.Columns["id"].HeaderText = "ID";
            dvgLivros.Columns["id"].Visible = false;

            dvgLivros.Columns["isbn"].HeaderText = "ISBN";
            dvgLivros.Columns["isbn"].Width = 130;

            dvgLivros.Columns["titulo"].HeaderText = "TÍTULO";
            dvgLivros.Columns["titulo"].Width = 300;
            dvgLivros.Columns["titulo"].DefaultCellStyle.Padding = new Padding(5,0,0,0);


            dvgLivros.Columns["autores"].HeaderText = "AUTORES";
            dvgLivros.Columns["autores"].Width = 300;
            dvgLivros.Columns["autores"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgLivros.Columns["autores"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgLivros.Columns["unitario"].HeaderText = "UNITARIO";
            dvgLivros.Columns["unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dvgLivros.Columns["unitario"].DefaultCellStyle.Format = "n2";
            dvgLivros.Columns["unitario"].DefaultCellStyle.Padding = new Padding(0,0,5,0);

            dvgLivros.Columns["saldo_inicial"].HeaderText = "SALDO";
            dvgLivros.Columns["saldo_inicial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            

        }

        private void dvgLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
