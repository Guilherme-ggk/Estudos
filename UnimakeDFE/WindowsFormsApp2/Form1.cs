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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FORMSHOW(Form FRM)
        {
            BUTTONCLOSE();
            FRMATIVO = FRM;
            FRM.TopLevel = false;
            PanelForm.Controls.Add(FRM);
            FRM.BringToFront();
            FRM.Show();
        }

        private void ACTIVEBUTTON(Button FRMATIVO)
        {
            foreach(Control Ctrl in PanelPrincipal.Controls)
                Ctrl.ForeColor = Color.Black;

            FRMATIVO.ForeColor = Color.Blue;
        }
        private void BUTTONCLOSE()
        {
            if (FRMATIVO != null)
                FRMATIVO.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ACTIVEBUTTON(BtnHome);
            BUTTONCLOSE();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            ACTIVEBUTTON(BtnConfig);
            FORMSHOW(new FrmConfig());
            
        }
    }
}
