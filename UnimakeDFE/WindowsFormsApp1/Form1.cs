using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Form FRMATIVO;

        private void FORMSHOW(Form FMR)
        {
            FRMATIVO = FMR;
            FMR.TopLevel = false;
            PanelForm.Controls.Add(FMR);   
            FMR.BringToFront();
            FMR.Show();
        }

        private void ACTIVEBUTTON(Button FRMATIVO)
        {
            foreach (Control control in PanelPrincipal.Controls)
                control.ForeColor = Color.Black;
                FRMATIVO.ForeColor = Color.Red;
        }
        private void ACTIVEFORMCLOSE()
        {
            if (FRMATIVO != null)
                FRMATIVO.Close();


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ACTIVEBUTTON(BtnHome);
            ACTIVEFORMCLOSE();

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ACTIVEBUTTON(BtnClientes);
            FORMSHOW(new FrmClientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ACTIVEBUTTON(button2);
            FORMSHOW(new FrmFornecedores());
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            ACTIVEBUTTON(BtnProdutos);
            FORMSHOW(new FrmProdutos());
        }
    }
}
