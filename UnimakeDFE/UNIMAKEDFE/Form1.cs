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
using Unimake.Business.DFe.Xml.NFe;
using Unimake.Security.Platform;


namespace UNIMAKEDFE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Certificado Digital

        //Caminho do Certificado Digital
        private static string PathCertificadoDigital { get; set; } = "C:\\Users\\30755\\Downloads\\HS BERNARDO - COMERCIO DE CARNES LTDA Senha 30163001 Val 19.11.2025 1006927767.pfx";
        //Senha do certificado Digital
        private static string SenhaCertificado { get; set; } = "30163001";

        //Campo do Certificado Digital
        public static X509Certificate2 CertificadoDigitalField;

        public static X509Certificate2 CertificadoSelecionado
        {
            get
            {
                if (CertificadoDigitalField == null)
                {
                    CertificadoDigitalField = new CertificadoDigital().CarregarCertificadoDigitalA1(PathCertificadoDigital, SenhaCertificado);
                }
                return CertificadoDigitalField;
            }
            private set => throw new Exception("não é possivel carregar certificado digital, carregado automaticamente!");
        }

        #endregion
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

            MessageBox.Show(StatusServico.Result.CStat + " - " + StatusServico.Result.XMotivo);
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

            MessageBox.Show(ConsultaProtocolo.Result.CStat + " - " + ConsultaProtocolo.Result.XMotivo);
        }

        private void BtnEnvioSincrono_Click(object sender, EventArgs e)
        {
            var xml = new EnviNFe
            {
                Versao = "4.00",
                IdLote = "0000000000000001",
                IndSinc = SimNao.Nao,
                NFe = new List<NFe>
                {
                    new NFe
                    {
                        InfNFe = new List<InfNFe>
                        {
                           new InfNFe
                           {
                               Versao = "4.00",
                               Ide = new Ide
                               {
                                   CUF = UFBrasil.PR,
                                   NatOp = "VENDA",
                                   Mod = ModeloDFe.NFe,
                                   Serie = 1,
                                   NNF = 57972,
                                   DhEmi = DateTime.Now,
                                   DhSaiEnt = DateTime.Now,
                                   TpNF = TipoOperacao.Saida,
                                   IdDest = DestinoOperacao.OperacaoInterestadual,
                                   CMunFG = 4118402,
                                   TpImp = FormatoImpressaoDANFE.NormalRetrato,
                                   TpEmis = TipoEmissao.Normal,
                                   TpAmb = TipoAmbiente.Homologacao,
                                   FinNFe = FinalidadeNFe.Normal,
                                   IndFinal = SimNao.Sim,
                                   IndPres = IndicadorPresenca.OperacaoPresencial,
                                   ProcEmi = ProcessoEmissao.AplicativoContribuinte,
                                   VerProc = "TESTE 1.00"
                               },
                               Emit = new Emit
                               {
                                   CNPJ = "",
                                   XNome = "",
                                   XFant = "",
                                   EnderEmit = new EnderEmit
                                   {
                                       XLgr = "",
                                       Nro = "",
                                       XBairro = "",
                                       CMun = 4118402,
                                       XMun = "",
                                       UF = UFBrasil.PR,
                                       CEP = "",
                                       Fone = ""

                                   },
                                   IE = "",
                                   IM = "",
                                   CNAE = "",
                                   CRT = CRT.SimplesNacional

                               },
                               Dest = new Dest
                               {
                                   CNPJ = "",
                                   XNome = "",
                                   EnderDest = new EnderDest
                                   {
                                       XLgr = "",
                                       Nro = "",
                                       XBairro = "",
                                       CMun = 1,
                                       XMun = "",
                                       UF = UFBrasil.PR,
                                       CEP = "",
                                       Fone = ""
                                   },
                                   IndIEDest = IndicadorIEDestinatario.ContribuinteICMS,
                                   IE = "",
                                   Email = ""
                               },
                               Det = new List<Det>
                               {
                                   new Det
                                   {
                                       NItem = 1,
                                       Prod = new Prod
                                       {
                                           CProd = "",
                                           CEAN = "SEM GTIN",
                                           XProd = "",
                                           NCM = "",
                                           CFOP = "",
                                           UCom = "",
                                           QCom = 1.00m,
                                           VUnCom = 84.9000000000m,
                                           VProd = 84.90,
                                           CEANTrib = "SEM GTIN",
                                           UTrib = "",
                                           QTrib = 1.00m,
                                           VUnTrib = 84.90000000000m,
                                           IndTot = SimNao.Sim,
                                           XPed = "",
                                           NItemPed = "",

                                       }, Imposto = new Imposto
                                       {
                                           VTotTrib = 12.63,
                                           //ICMS = new List<ICMS>
                                           //{
                                           //    new ICMS
                                           //    {
                                           //        ICMSSN101 = new ICMSSN101
                                           //        {
                                           //            Orig = OrigemMercadoria.Nacional,
                                           //            PCredSN = 2.8225,
                                           //            VCredICMSSN = 2.40,
                                           //        }
                                           //    }
                                           //},
                                           PIS = new PIS
                                           {
                                               PISOutr = new PISOutr
                                               {
                                                   CST = "",
                                                   VBC = 0.00,
                                                   PPIS = 0.00,
                                                   VPIS = 0.00
                                               }
                                           },
                                           COFINS = new COFINS
                                           {
                                               COFINSOutr = new COFINSOutr
                                               {
                                                   CST = "99",
                                                   VBC = 0.00,
                                                   PCOFINS = 0.00,
                                                   VCOFINS = 0.00
                                               }
                                           }
                                       }

                                   },
                                   new Det
                                   {
                                       NItem = 2,
                                       Prod = new Prod
                                       {
                                           CProd = "",
                                           CEAN = "SEM GTIN",
                                           XProd = "",
                                           NCM = "",
                                           CFOP = "",
                                           UCom = "",
                                           QCom = 1.00m,
                                           VUnCom = 84.9000000000m,
                                           VProd = 84.90,
                                           CEANTrib = "SEM GTIN",
                                           UTrib = "",
                                           QTrib = 1.00m,
                                           VUnTrib = 84.90000000000m,
                                           IndTot = SimNao.Sim,
                                           XPed = "",
                                           NItemPed = "",
                                       },  Imposto = new Imposto
                                       {
                                           VTotTrib = 12.63,
                                           //ICMS = new List<ICMS>
                                           //{
                                           //    new ICMS
                                           //    {
                                           //        ICMSSN101 = new ICMSSN101
                                           //        {
                                           //            Orig = OrigemMercadoria.Nacional,
                                           //            PCredSN = 2.8225,
                                           //            VCredICMSSN = 2.40,
                                           //        }
                                           //    }
                                           //},
                                           PIS = new PIS
                                           {
                                               PISOutr = new PISOutr
                                               {
                                                   CST = "",
                                                   VBC = 0.00,
                                                   PPIS = 0.00,
                                                   VPIS = 0.00
                                               }
                                           },
                                           COFINS = new COFINS
                                           {
                                               COFINSOutr = new COFINSOutr
                                               {
                                                   CST = "99",
                                                   VBC = 0.00,
                                                   PCOFINS = 0.00,
                                                   VCOFINS = 0.00
                                               }
                                           }
                                       }
                                   }
                               },
                               Total = new Total
                               {
                                   ICMSTot = new ICMSTot
                                   {
                                       VBC = 0,
                                       VICMS = 0,
                                       VICMSDeson = 0,
                                       VFCP = 0,
                                       VBCST = 0,
                                       VST = 0,
                                       VFCPST = 0,
                                       VFCPSTRet = 0,
                                       VProd = 169.80,
                                       VFrete =0,
                                       VSeg = 0,
                                       VDesc = 0,
                                       VII = 0,
                                       VIPI = 0,
                                       VIPIDevol = 0,
                                       VPIS = 0,
                                       VCOFINS = 0,
                                       VOutro = 0,
                                       VNF = 0,
                                       VTotTrib = 25.26
                                   }
                               },
                               Transp = new Transp
                               {
                                   ModFrete = ModalidadeFrete.ContratacaoFretePorContaRemetente_CIF,
                                   Vol = new List<Vol>
                                   {
                                       new Vol
                                       {
                                           QVol = 1,
                                           Esp = "LU",
                                           Marca = "UNIMAKE",
                                           PesoL = 0.000,
                                           PesoB = 0.000
                                       }
                                   }
                               },
                               Cobr = new Cobr()
                               {
                                   Fat = new Fat
                                   {
                                       NFat = "",
                                       VOrig = 169.80,
                                       VDesc = 0,
                                       VLiq = 169.80
                                   },
                                   Dup = new List<Dup>
                                   {
                                       new Dup
                                       {
                                           NDup = "001",
                                           DVenc = DateTime.Now,
                                           VDup = 169.80

                                       }
                                   }
                               },
                               Pag = new Pag
                               {
                                   DetPag = new List<DetPag>
                                   {
                                       new DetPag
                                       {
                                           IndPag = IndicadorPagamento.PagamentoVista,
                                           TPag = MeioPagamento.Dinheiro,
                                           VPag = 169.80
                                       }
                                   }
                               },
                               InfAdic = new InfAdic
                               {
                                   InfCpl = ";CONTROLE: ; PEDIDO(S) ATENDIDO(S): ; Empresa optante pelo simples nacional, conforme lei compl. 128 de 19/12"
                               },
                               InfRespTec = new InfRespTec
                               {
                                   CNPJ = "",
                                   XContato = "",
                                   Email = "",
                                   Fone = ""
                               }

                           }
                        }
                    }
                }

            };
        }
    }
}
