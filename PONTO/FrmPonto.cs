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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NITGEN.SDK.NBioBSP;
using NEGOCIO;
using TRANSFERENCIA;
using System.IO;

namespace Ponto
{
    public partial class FrmPonto : Syncfusion.Windows.Forms.MetroForm
    {
        public FrmPonto()
        {
            InitializeComponent();
        }

        private void toggleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Colaborador ProcurarColaborador(NBioAPI.Type.HFIR digital)
        {            
            ColaboradorNegocio colaboradorNegocio = new ColaboradorNegocio();
            LeitorBiometrico leitor = new LeitorBiometrico();
            List<Colaborador> colaboradorColecao = colaboradorNegocio.ConsultarPorNome("");

            foreach (Colaborador colaborador in colaboradorColecao)
            {                
                if (leitor.Verificar(colaborador.Digital, digital))
                {
                    leitor = null;
                    return colaborador;
                }                
            }

            leitor = null;
            return null;
        }

        private void RegistrarPonto()
        {
            //Recebe a digital, verifica se existe o colaborador com essa digital e retorna os dados do colaborador
            LeitorBiometrico leitor = new LeitorBiometrico();
            Colaborador colaborador = new Colaborador();
            colaborador = ProcurarColaborador(leitor.Capturar());

            //Registra o acesso no banco de dados
            Acesso acesso = new Acesso();
            AcessoNegocio acessoNegocio = new AcessoNegocio();
            try
            {
                try
                {
                    int verifica = Convert.ToInt32(colaborador.Id);
                    acesso.IdColaborador = colaborador.Id;
                    acesso.Digital = colaborador.Digital;
                    acessoNegocio.RegistrarPonto(acesso);

                    //Busca o acesso que acabou de ser realizado
                    UVWACESSO uvwAcesso = new UVWACESSO();
                    uvwAcesso = acessoNegocio.ConsultarUltimoAcesso(colaborador.Id);

                    //preenche os campos
                    if (uvwAcesso.DataHoraSaida.ToString() == "01/01/2001 00:00:00")
                    {
                        lblNome.Text = uvwAcesso.Nome;
                        lblCrm.Text = uvwAcesso.Crm;
                        lblDataHoraEntrada.Text = uvwAcesso.DataHoraEntrada.ToString();
                        lblDataHoraSaida.Visible = false;
                        lblDataHoraSaidaLeitura.Visible = false;
                        lblTempoTotal.Visible = false;
                        lblTempoTotalLeitura.Visible = false;
                        lblPrincipal.Text = "ENTRADA REGISTRADA COM SUCESSO. BOM TRABALHO!";
                        //Mostra a foto no campo PictureBox
                        if (uvwAcesso.Foto != null)
                        {
                            try
                            {
                                MemoryStream memory = new MemoryStream(uvwAcesso.Foto);
                                pictureBox1.Image = Image.FromStream(memory);
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Erro ao mostrar a foto. Detalhes:" + ex.Message);                                
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                        //Termina a amostra da foto
                    }
                    else
                    {
                        lblNome.Text = uvwAcesso.Nome;
                        lblCrm.Text = uvwAcesso.Crm;
                        lblDataHoraEntrada.Text = uvwAcesso.DataHoraEntrada.ToString();
                        lblDataHoraSaida.Visible = true;
                        lblDataHoraSaida.Text = uvwAcesso.DataHoraSaida.ToString();
                        lblDataHoraSaidaLeitura.Visible = true;
                        lblTempoTotal.Visible = true;
                        lblTempoTotal.Text = uvwAcesso.TempoTotal;
                        lblTempoTotalLeitura.Visible = true;
                        lblPrincipal.Text = "SAÍDA REGISTRADA COM SUCESSO. BOM DESCANSO!";
                        //Mostra a foto no campo PictureBox
                        if (uvwAcesso.Foto != null)
                        {
                            try
                            {
                                MemoryStream memory = new MemoryStream(uvwAcesso.Foto);
                                pictureBox1.Image = Image.FromStream(memory);
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Erro ao mostrar a foto. Detalhes:" + ex.Message);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                        //Termina a amostra da foto
                    }

                    panDadosAcesso.Visible = true;
                    timer1.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível localizar o Médico. Tente novamente!");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            


        }

        private void btnRegistrarPonto_Click(object sender, EventArgs e)
        {
            RegistrarPonto();
        }

        private void FrmPonto_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panDadosAcesso.Visible = false;
            timer1.Stop();
        }

        private void lblTempoTotal_Click(object sender, EventArgs e)
        {

        }

        private void FrmPonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegistrarPonto();
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja finalizar o sistema de ponto?", "Verificação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    Close();

                }
                else
                {
                    return;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
