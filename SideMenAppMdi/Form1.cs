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
        

        public Form1()
        {
            InitializeComponent();
        }

      
        
      

       


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void op1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmConfig>().Count() == 0)
            {
                FrmConfig frm = new FrmConfig();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms.OfType<FrmConfig>().First().WindowState = FormWindowState.Normal;
                Application.OpenForms.OfType<FrmConfig>().First().BringToFront();
            }
        }

        private void op2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 0)
            {
                Form2 frm = new Form2();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms.OfType<Form2>().First().WindowState = FormWindowState.Normal;
                Application.OpenForms.OfType<Form2>().First().BringToFront();
            }
        }
    }
}
