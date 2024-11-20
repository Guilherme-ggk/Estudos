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
            var xml = new ConsStatServ
            {
                Versao = "4.00",
                CUF = UFBrasil.PR,
                TpAmb = TipoAmbiente.Homologacao
            };

            var configuracao = new Configuracao
            {
                CertificadoDigital = CertificadoSelecionado,
                TipoDFe = TipoDFe.NFe,
                TipoEmissao = TipoEmissao.Normal
            };

            var StatusServico = new StatusServico(xml, configuracao);
            StatusServico.Executar();

            MessageBox.Show(StatusServico.Result.CStat + " " + StatusServico.Result.XMotivo);

                
        }

        private void BtnConsultaSituacao_Click(object sender, EventArgs e)
        {

            var xml = new ConsSitNFe
            {
                Versao = "4.00",
                TpAmb = TipoAmbiente.Homologacao,
                ChNFe = "41241135547526000170550010000019261000019274"
            };

            var configuracao = new Configuracao
            {
                CertificadoDigital = CertificadoSelecionado,
                TipoDFe = TipoDFe.NFe,
                TipoEmissao = TipoEmissao.Normal
            };

            var ConsultaProtocolo = new ConsultaProtocolo(xml, configuracao);
            ConsultaProtocolo.Executar();

            MessageBox.Show(ConsultaProtocolo.Result.CStat + " " + ConsultaProtocolo.Result.XMotivo);
        }

        #region

        private static string PathCertificadoDigital { get; set; } = "C:\\Users\\30755\\Downloads\\HS BERNARDO - COMERCIO DE CARNES LTDA Senha 30163001 Val 19.11.2025 1006927767.pfx";
        private static string SenhaCertificado { get; set; } = "30163001";

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
