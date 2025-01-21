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

        private void ButtonActive(Button FRMATIVO)
        {
            foreach(Control controle in PanelPrincipal.Controls)
                controle.ForeColor = Color.White;

            FRMATIVO.ForeColor = Color.Red;
        }
        private void ButtonClose()
        {
            if(FRMATIVO != null)
               FRMATIVO.Close();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnConfig);
            FormShow(new FrmConfig());
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnHome);
            ButtonClose();
        }


        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
