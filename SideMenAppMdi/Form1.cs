using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideMenAppMdi
{
    public partial class Form1 : Form
    {
        private Form FrmAtivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void FormShow(Form Frm)
        {
            ButtonClose();
            FrmAtivo = Frm;
            Frm.TopLevel = false;
            PanelForm.Controls.Add(Frm);
            Frm.BringToFront();
            Frm.Show();
        }
        
        private void ButtonClose()
        {
            if(FrmAtivo != null)
                FrmAtivo.Close();
        }

        private void ButtonActive(Button FrmAtivo)
        {
            foreach(Control controle in PanelPrincipal.Controls)
                controle.ForeColor = Color.Black;

                FrmAtivo.ForeColor = Color.Blue;

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnHome);
            ButtonClose();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnConfig);
            FormShow(new FrmConfig());
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
