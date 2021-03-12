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
using NEGOCIO;
using TRANSFERENCIA;

namespace APRESENTACAO
{
    public partial class FrmRelatorioPontoGeral : Syncfusion.Windows.Forms.MetroForm
    {
        Colaborador colaborador = new Colaborador();
        public FrmRelatorioPontoGeral()
        {
            InitializeComponent();
        }

        private void atualizaGrid()
        {
            try
            {
                ColaboradorNegocio colaboradorNegocio = new ColaboradorNegocio();
                //ColaboradorColecao colaboradorColecao = new ColaboradorColecao();

                List<Colaborador> colaboradorColecao= colaboradorNegocio.ConsultarPorNome(txtPesquisar.Text);
                dgvConsultaCRUD.DataSource = colaboradorColecao;

                dgvConsultaCRUD.Update();
                dgvConsultaCRUD.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                colaborador = null;
                FrmRelatorioPontoGeralPreview Preview = new FrmRelatorioPontoGeralPreview(dtpInicialGeral.Value, dtpFinalGeral.Value, colaborador);
                DialogResult retorno = Preview.ShowDialog();
                if (retorno == DialogResult.Yes)
                {
                    Preview = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir o relatório de ponto. Detalhes: " + ex.Message);
            };
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpInicialGeral_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmRelatorioPontoGeral_Load(object sender, EventArgs e)
        {
          
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void btnGerarRelatorioMedico_Click(object sender, EventArgs e)
        {
            try
            {
                colaborador = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as Colaborador);
                FrmRelatorioPontoGeralPreview Preview = new FrmRelatorioPontoGeralPreview(dtpInicialMedico.Value, dtpFinalMedico.Value, colaborador);
                DialogResult retorno = Preview.ShowDialog();
                if (retorno == DialogResult.Yes)
                {
                     Preview = null;
                     colaborador = null;
                }
            }               
            
            catch (Exception)
            {
                MessageBox.Show("Selecione um médico no grid.");
                atualizaGrid();
            }
        }

        private void gradientLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
