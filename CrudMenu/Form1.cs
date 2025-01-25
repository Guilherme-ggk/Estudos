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
        private Form FrmAtivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClose()
        {
            if(FrmAtivo != null)
                FrmAtivo.Close();
        }
        private void ButtonActive(Button FRMAITVO)
        {
            foreach(Control controle in PanelPrincipal.Controls)
                controle.ForeColor = Color.Black;

            FRMAITVO.ForeColor = Color.Red;   
        }
        private void FormShow(Form frm)
        {
            ButtonClose();
            FrmAtivo = frm;
            frm.TopLevel = false;
            PanelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnHome);
            ButtonClose();
        }

        private void BtnBanco_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnBanco);
            FormShow(new FrmDataBase());
        }
    }
}
