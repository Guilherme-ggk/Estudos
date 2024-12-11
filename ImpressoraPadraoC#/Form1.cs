using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpressoraPadraoC_
{
    public partial class Form1 : Form
    {
        [DllImport("winspool.drv", SetLastError = true, CharSet = CharSet.Ansi)]
        public static  extern bool SetDefaultPrinter(string Name);
        public Form1()
        {
            InitializeComponent();
            GetImpressoras();
            
            listBox1.Text = LblImpressoraPadrao.Text;
        }
        public void GetImpressoras()
        {
            foreach (string impressora in PrinterSettings.InstalledPrinters)
                listBox1.Items.Add(impressora);
        }
        private string GetImpressoraPadrao()
        {
            var Impressora = new PrinterSettings();
            return Impressora.PrinterName;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(SetDefaultPrinter(listBox1.Text))
                LblImpressoraPadrao.Text = listBox1.Text;
        }
    }
}
