using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideMenuC_
{
    public partial class FrmPrincipal : Form
    {
        private Form FrmAtivo;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FormShow(Form frm)
        {
            //  ActiveFormClose();
            FrmAtivo = frm;
            frm.TopLevel = false;
            PanelForm.Controls.Add(frm);
            FrmAtivo.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if(FrmAtivo != null)
                FrmAtivo.Close();
        }

        private void ActiveButton(Button FrmAtivo)
        {
            foreach(Control ctrl in PanelPrincipal.Controls)
                ctrl.ForeColor = Color.White;

            FrmAtivo.ForeColor = Color.Red;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnHome);
            ActiveFormClose();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnProdutos);
            FormShow(new FrmProdutos());
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnClientes);
            FormShow(new FrmClientes());
        }

        private void BtnVendedores_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnVendedores);
            FormShow(new FrmVendedores());
        }
    }
}
