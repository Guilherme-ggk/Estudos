using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudGelt
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

        private void BtnData_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnData);
            FormShow(new FormData());
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(BtnHome);
            FormClose();
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


        public void ActiveButton(Button FrmAtivo)
        {
            foreach(Control Ctrl in PanelPrincipal.Controls)
                Ctrl.ForeColor = Color.Red;

            FrmAtivo.ForeColor = Color.Green;
        }

    }
}
