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
            var xml = new ConsStatServ  //Montando XML
            {
                Versao = "4.00", // versão
                CUF = UFBrasil.PR, //localização
                TpAmb = TipoAmbiente.Homologacao //Tipo ambiente
            };
            //primeiro ele controi o obrjeto xml, contori a config, com certificado, servico, tipo de emissao e dfe, com isso depois ele puxa mais detalhes, 
            //depois executa e consome o servico, status mostra todos os detalhes do retorno da sefaz

            var configuracao = new Configuracao
            {
                TipoDFe = TipoDFe.NFe,
                TipoEmissao = TipoEmissao.Normal,
                CertificadoDigital = CertificadoSelecionado,

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
                ChNFe = ""
            };

            var configuracao = new Configuracao
            {
                TipoDFe = TipoDFe.NFe,
                TipoEmissao = TipoEmissao.Normal,
                CertificadoDigital = CertificadoSelecionado
            };

            var consultaProtocolo = new ConsultaProtocolo(xml, configuracao);
            consultaProtocolo.Executar();

            MessageBox.Show(consultaProtocolo.Result.CStat + " " + consultaProtocolo.Result.XMotivo);


        }

        #region Certificado digital

        //Caminho do certificado digital A1
        private static string PathCertificadoDigital { get; set; } = @"C:\Users\30755\Downloads\file.p12";

        //Senha do certificado digital 
        private static string SenhaCertificadoDigital { get; set; } = "30163001";

        private static X509Certificate2 CertificadoSelecionadoField; // Todo certificado digital alimenta essa propriedade
        

        public static X509Certificate2 CertificadoSelecionado // trabalho de carregar o certificado
        {
            get // pega 
            {
                if (CertificadoSelecionadoField == null) // se for nulo ele carrega o certificado e senha
                {
                    CertificadoSelecionadoField = new CertificadoDigital().CarregarCertificadoDigitalA1(PathCertificadoDigital, SenhaCertificadoDigital);
                }

                return CertificadoSelecionadoField;
            }

            //diz que não pode carregar manualmente por que ele já vai resgatar de forma automatica
            private set => throw new Exception("Não é possivel atribuir um certificado digital! Somente resgate o valor da propriedade que o certificado é definido automaticamente.");
        }


        
        #endregion
    }
}
