using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud3._0
{
    public partial class Form1 : Form
    {
        Form FrmAtivo;
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
            foreach (Control ctrl in PanelPrincipal.Controls)
                ctrl.ForeColor = Color.White;

            FrmAtivo.ForeColor = Color.White;
        }

        public void FormShow(Form frm)
        {
            ButtonClose();
            FrmAtivo = frm;
            frm.TopLevel = false;
            PanelForm.Controls.Add(frm);
            frm.BringToFront();     
            frm.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnHome);
            ButtonClose();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnData);
            FormShow(new FormDados());
        }
    }
}
