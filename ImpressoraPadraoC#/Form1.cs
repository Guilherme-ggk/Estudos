using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpressoraPadraoC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetImpressoras();
        }
        public void GetImpressoras()
        {
            foreach (string impressora in PrinterSettings.InstalledPrinters)
                listBox1.Items.Add(impressora);
        }
    }
}
