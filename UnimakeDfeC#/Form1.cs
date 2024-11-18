using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnimakeDfeC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConsultaStatus_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultaSituacao_Click(object sender, EventArgs e)
        {

        }

        #region Certificado digital

        //Caminho do certificado digital A1
        private static string PathCertificadoDigital { get; set; } = @"C:\Unimake\UnimakePV.pfx";

        //Senha do certificado digital 
        private static string SenhaCertificadoDigital { get; set; } = "123456789";

        private static X509Certificate2 CertificadoSelecionadoField; // Todo certificado digital alimenta essa propriedade
        

        public static X509Certificate2 CertificadoSelecionado
        {
            get
            {

            }
        }



        #endregion
    }
}
