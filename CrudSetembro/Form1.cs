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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
          
        }


        Form FrmAtivo;

        private void FormShow(Form Frm)
        {
            FormClose();
            FrmAtivo = Frm;
            Frm.TopLevel = false;
            PanelForm.Controls.Add(Frm);
            Frm.BringToFront();
            Frm.Show();
        }

        private void FormClose()
        {
            if(FrmAtivo != null)
            {
                FrmAtivo.Close();
            }
        }

        private void ButtonActive(Button FrmAtivo)
        {
            foreach(Control Ctrl in PanelPrincipal.Controls)
                Ctrl.ForeColor = Color.Black;

            FrmAtivo.ForeColor = Color.Blue;
        }
    }
}
