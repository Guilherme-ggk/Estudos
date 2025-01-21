using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Form FRMATIVO;
        public Form1()
        {
            InitializeComponent();
        }

        private void FormShow(Form FRM)
        {
            ButtonClose();
            FRMATIVO = FRM;
            FRM.TopLevel = false;
            PanelForm.Controls.Add(FRM);
            FRM.BringToFront();
            FRM.Show();

        }

        private void ActiveButton(Button FRMATIVO)
        {
            foreach (Control c in PanelPrincipal.Controls) ;
              //  c.ForeColor = Color.Black;

           // FRMATIVO.ForeColor = Color.Black;
        }

        private void ButtonClose()
        {
            if (FRMATIVO != null)
                FRMATIVO.Close();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnHome);
            ButtonClose();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnConfig);
            FormShow(new FrmConfig());
        }
    }
}
