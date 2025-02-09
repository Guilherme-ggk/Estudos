﻿using System;
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
using Unimake.Formatters;
using ConsStatServ = Unimake.Business.DFe.Xml.NFe.ConsStatServ;
using Dest = Unimake.Business.DFe.Xml.NFe.Dest;
using Emit = Unimake.Business.DFe.Xml.NFe.Emit;
using EnderEmit = Unimake.Business.DFe.Xml.NFe.EnderEmit;
using Ide = Unimake.Business.DFe.Xml.NFe.Ide;


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
                if(CertificadoDigitalField == null)
                {
                    CertificadoDigitalField = new CertificadoDigital().CarregarCertificadoDigitalA1(PathCertificadoDigital, SenhaCertificado);
                }
                return CertificadoDigitalField;
            }
            private set => throw new Exception("não é possivel carregar certificado digital, carregado automaticamente!");
        }

        #endregion

        private void BtnEnviarNFeSincrono_Click(object sender, EventArgs e)
        {
            var xml = new EnviNFe
            {
                Versao = "4.00",
                IdLote = "00000000000001",
                IndSinc = SimNao.Sim,
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
                                    NatOp = "VENDA PRODUÇÃO. ESTABELEC",
                                    Mod = ModeloDFe.NFe,
                                    Serie = 1,
                                    NNF = 57980,
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
                                       Nro = "1500",
                                       XBairro = "",
                                       CMun = 1,
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
                                    EnderDest = new Unimake.Business.DFe.Xml.NFe.EnderDest
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
                                Det = new List<Unimake.Business.DFe.Xml.NFe.Det>
                                {
                                    new Unimake.Business.DFe.Xml.NFe.Det
                                    {
                                        NItem = 1,
                                        Prod = new Unimake.Business.DFe.Xml.NFe.Prod
                                        {
                                            CProd = "",
                                            CEAN = "",
                                            XProd = "",
                                            NCM = "",
                                            CFOP = "",
                                            UCom = "",
                                            QCom = 1,
                                            VUnCom = 84.9000000000m,
                                            VProd = 84.90,
                                            CEANTrib = "SEM GTIN",
                                            UTrib = "LU",
                                            QTrib = 1.00m,
                                            VUnTrib = 84.9000000000m,
                                            IndTot = SimNao.Sim,
                                            XPed = "",
                                            NItemPed = "1"

                                        }, 
                                        Imposto = new Unimake.Business.DFe.Xml.NFe.Imposto
                                        {
                                            VTotTrib = 12.63,
                                            ICMS = new List<ICMS>
                                            {
                                                new ICMS
                                                {
                                                    ICMSSN101 = new ICMSSN101
                                                    {
                                                        Orig = OrigemMercadoria.Nacional,
                                                        PCredSN = 2.8255,
                                                        VCredICMSSN = 2.40
                                                    }
                                                }
                                            },
                                            PIS = new Unimake.Business.DFe.Xml.NFe.PIS
                                            {
                                                PISOutr = new PISOutr
                                                {
                                                    CST = "99",
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
                                    new Unimake.Business.DFe.Xml.NFe.Det
                                    {
                                        NItem = 2,
                                        Prod = new Unimake.Business.DFe.Xml.NFe.Prod
                                        {
                                            CProd = "11111",
                                            CEAN = "SEM GTIN",
                                            XProd = "TESTE DO PRODUTO DO ITEM 2",
                                            NCM = "84714900",
                                            CFOP = "6101",
                                            UCom = "LU",
                                            QCom = 1.00m,
                                            VUnCom = 84.9000000000m,
                                            VProd = 84.90,
                                            CEANTrib = "SEM GTIN",
                                            UTrib = "LU",
                                            QTrib = 1.00m,
                                            VUnTrib = 84.9000000000m,
                                            IndTot = SimNao.Sim,
                                            XPed = "300474",
                                            NItemPed = "1"
                                        },
                                        Imposto = new Unimake.Business.DFe.Xml.NFe.Imposto
                                        {
                                            VTotTrib = 12.63,
                                            ICMS = new List<ICMS>
                                            {
                                                new ICMS
                                                {
                                                    ICMSSN101 = new ICMSSN101
                                                    {
                                                        Orig = OrigemMercadoria.Nacional,
                                                        PCredSN = 2.8255,
                                                        VCredICMSSN = 2.40
                                                    }
                                                }
                                            },
                                            PIS = new Unimake.Business.DFe.Xml.NFe.PIS
                                            {
                                                PISOutr = new PISOutr
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
