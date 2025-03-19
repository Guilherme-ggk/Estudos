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
using Unimake.Business.DFe.Xml.NFe;
using Unimake.Security.Platform;
using Unimake.Business.DFe.Servicos;
using Unimake.Business.DFe.Servicos.NFe;

namespace ProjetoUnimakeNF
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
                TipoDFe = TipoDFe.NFe,
                TipoEmissao = TipoEmissao.Normal,
                CertificadoDigital = CertificadoSelecionado
            };

            var statusServico = new StatusServico(xml, configuracao);
            statusServico.Executar();

            MessageBox.Show(statusServico.Result.CStat + "" + statusServico.Result.XMotivo);
        }

        private void BtnConsultaSituacao_Click(object sender, EventArgs e)
        {
            var xml = new ConsSitNFe
            {
                Versao = "4.00",
                TpAmb = TipoAmbiente.Homologacao,
                ChNFe = ""
            };

            var configuracao = new Configuracao
            {
                TipoDFe = TipoDFe.NFe,
                TipoEmissao = TipoEmissao.Normal,
                CertificadoDigital = CertificadoSelecionado
            };

            var Consulta = new ConsultaProtocolo(xml, configuracao);
            Consulta.Executar();

            MessageBox.Show(Consulta.Result.CStat + " " + Consulta.Result.XMotivo);
        }

        

        #region Certificado digital


        private static string PathCertificadoDigital { get; set; } = "C:\\Users\\30755\\Downloads\\HS BERNARDO - COMERCIO DE CARNES LTDA Senha 30163001 Val 19.11.2025 1006927767.pfx";

        private static string SenhaCertificadoDigital { get; set; } = "30163001";

        private static X509Certificate2 CertificadoSelecionadoField;

        public static X509Certificate2 CertificadoSelecionado
        {
            get
            {
                if(CertificadoSelecionadoField == null)
                {
                    CertificadoSelecionadoField = new CertificadoDigital().CarregarCertificadoDigitalA1(PathCertificadoDigital, SenhaCertificadoDigital);
                }

                return CertificadoSelecionadoField;
            }

            private set => throw new Exception("Não é possivel atribuir um certificado digital! Somente resgate o valor da propriedade que o certificado é definido automaticamente."); 
        }


      


        #endregion
    }
}
