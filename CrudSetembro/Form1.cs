using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudSetembro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        public void FormClose()
        {
            if(FrmAtivo != null)
                FrmAtivo.Close();
        }

        public void ButtonActive(Button FrmAtivo)
        {
            foreach(Control Ctrl in PanelPrincipal.Controls)
                Ctrl.ForeColor = Color.Black;

            FrmAtivo.ForeColor = Color.Blue;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnData);
            FormClose();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            ButtonActive(BtnData);
            FormShow(new FormData());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
