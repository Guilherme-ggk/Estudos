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
    public partial class Form1 : Form
    {
        public Form FrmAtivo;
        public Form1()
        {
            InitializeComponent();
        }
        public void ButtonClose()
        {
            if(FrmAtivo != null)
                FrmAtivo.Close();
        }
        public void ButtonActive(Button FrmAtivo)
        {
            foreach(Control controle in PanelPrincipal.Controls)
                controle.ForeColor = Color.Black;

            FrmAtivo.ForeColor = Color.Green;
        }
        public void FormShow(Form Frm)
        {
            ButtonClose();
            FrmAtivo = Frm;
            Frm.TopLevel = false;
            PanelForm.Controls.Add(Frm);
            Frm.BringToFront();
            Frm.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnHome);
            ButtonClose();
        }

        private void BtnDados_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnDados);
            FormShow(new FrmBanco());
        }
    }
}
