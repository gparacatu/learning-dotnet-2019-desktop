#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using NEGOCIO;
using TRANSFERENCIA;

namespace APRESENTACAO
{
    public partial class FrmRelatorioPontoGeralPreview : Syncfusion.Windows.Forms.MetroForm
    {
        DateTime dataInicialRecebida, dataFinalRecebida;
        Colaborador colaboradorRecebido;
        public FrmRelatorioPontoGeralPreview(DateTime dataInicial, DateTime dataFinal, Colaborador colaborador)
        {
            InitializeComponent();
            dataInicialRecebida = dataInicial;
            dataFinalRecebida = dataFinal;
            colaboradorRecebido = colaborador;
        }



        private void FrmRelatorioPontoGeralPreview_Load(object sender, EventArgs e)
        {
            try
            {
                AcessoNegocio relatorio = new AcessoNegocio();
                if (colaboradorRecebido == null)
                {
                    ReportDataSource Ponto = new ReportDataSource("RelatorioPontoGeral2", relatorio.ConsultarPontosGeral(dataInicialRecebida, dataFinalRecebida));
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(Ponto);
                    List<ReportParameter> parametros = new List<ReportParameter>();
                    parametros.Add(new ReportParameter("DataInicial", dataInicialRecebida.ToString()));
                    parametros.Add(new ReportParameter("DataFinal", dataFinalRecebida.ToString()));
                    parametros.Add(new ReportParameter("Titulo", "RELATÓRIO DE PONTO - GERAL"));
                    reportViewer1.LocalReport.SetParameters(parametros);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    return;
                }
                else
                {
                    ReportDataSource Ponto = new ReportDataSource("RelatorioPontoGeral2", relatorio.ConsultarPontosMedico(dataInicialRecebida, dataFinalRecebida, colaboradorRecebido));
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(Ponto);
                    List<ReportParameter> parametros = new List<ReportParameter>();
                    parametros.Add(new ReportParameter("DataInicial", dataInicialRecebida.ToString()));
                    parametros.Add(new ReportParameter("DataFinal", dataFinalRecebida.ToString()));
                    parametros.Add(new ReportParameter("Titulo", "RELATÓRIO DE PONTO - MÉDICO"));
                    reportViewer1.LocalReport.SetParameters(parametros);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                }                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao gerar relatório TESTEEE. Detalhes: " + ex.Message);
            }

        }
    }
}
