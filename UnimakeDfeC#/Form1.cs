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
using Unimake.Business.DFe.Servicos;
using Unimake.Business.DFe.Servicos.NFe;
using Unimake.Business.DFe.Xml.GNRE;
using Unimake.Business.DFe.Xml.NF3e;
using Unimake.Business.DFe.Xml.NFe;
using Unimake.Business.Security;
using ConsStatServ = Unimake.Business.DFe.Xml.NFe.ConsStatServ;


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

        #region

        private static string PathCertificadoDigital { get; set; } = "";
        private static string SenhaCertificado { get; set; } = "";

        public static X509Certificate2 CertificadoDigitalField;

        public static X509Certificate2 CertificadoSelecionado
        {
            get
            {
                if(CertificadoDigitalField == null)
                {
                    CertificadoDigitalField = new CertificadoDigital().CarregarCertificadoDigitalA1(PathCertificadoDigital, SenhaCertificado);
                }
                return CertificadoDigitalField;
            }

            private set => throw new Exception("não é possivel carregar certificado digital, carregado automaticamente!");
        }
        #endregion

    }
}
