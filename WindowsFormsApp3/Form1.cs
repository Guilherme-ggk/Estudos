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
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnHome);
            FormClose();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnData);
            FormShow(new FormData());
        }

        Form FrmAtivo;

        public void FormShow(Form Frm)
        {
            FormClose();
            FrmAtivo = Frm;
            Frm.TopLevel = false;
            PanelForm.Controls.Add(Frm);
            Frm.BringToFront();
            Frm.Show();
        }

        public void ButtonActive(Button FrmAtivo)
        {
            foreach(Control ctrl in PanelPrincipal.Controls)
                ctrl.ForeColor= Color.Green;

            FrmAtivo.ForeColor = Color.Green;
        }

        public void FormClose()
        {
            if(FrmAtivo != null)
                FrmAtivo.Close();
        }  
    }
}
