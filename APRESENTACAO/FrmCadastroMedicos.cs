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
using NITGEN.SDK.NBioBSP;
using System.IO;
using System.Drawing.Imaging;

namespace APRESENTACAO
{
    public partial class FrmCadastroMedicos : Syncfusion.Windows.Forms.MetroForm
    {
        String EnrollDig;
        Bitmap bmp;
        public FrmCadastroMedicos()
        {

            InitializeComponent();
            
        }

        private void limparCampos()
        {
            MetodosPublicos.LimparCamposTexto(grbPrincipal);
            //btnSalvar.Enabled = true;
            //grbPrincipal.Enabled = true;
            btnEditarCliente.Enabled = false;
            grbPrincipal.Text = "Dados do Médico";
            picFoto.Image = null;
        }

        private void preencherColaborador()
        {
            //Preenche os text box com os dados do colaborador selecionado
            Colaborador colaborador = new Colaborador();
            colaborador = (dgvConsultaCRUD.SelectedRows[0].DataBoundItem as Colaborador);
            txtBairroCliente.Text = colaborador.Bairro;
            txtCelularCliente.Text = colaborador.Celular;
            txtCepCliente.Text = colaborador.Cep;
            txtCidadeCliente.Text = colaborador.Cidade;
            txtContatoCliente.Text = colaborador.TelContato;
            txtCrm.Text = colaborador.Crm;
            txtCrmUf.Text = colaborador.CrmUf;
            txtDataNascimentoCliente.Text = colaborador.DataCadastro.ToString();
            txtEmailCliente.Text = colaborador.Email;
            txtEstadoCliente.Text = colaborador.Uf;
            txtNomeCliente.Text = colaborador.Nome;
            txtRuaCliente.Text = colaborador.Rua;
            txtTelFixoCliente.Text = colaborador.TelFixo;
            cbbStatus.Text = colaborador.Status;
            txtId.Text = colaborador.Id.ToString();
            EnrollDig = colaborador.Digital;

            //Mostra a foto no campo PictureBox
            if (colaborador.Foto != null)
            {
                try
                {
                    MemoryStream memory = new MemoryStream(colaborador.Foto);                    
                    picFoto.Image = Image.FromStream(memory);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao mostrar a foto. Detalhes:" + ex.Message);
                    picFoto.Image = null;
                }
            }
            else
            {
                picFoto.Image = null;
            }
            //Termina a amostra da foto

            btnEditarCliente.Enabled = true;
        }

        private void atualizaGrid()
        {
            try
            {
                ColaboradorNegocio colaboradorNegocio = new ColaboradorNegocio();
                //ColaboradorColecao colaboradorColecao = new ColaboradorColecao();
                                
                List<Colaborador> colaboradorColecao = colaboradorNegocio.ConsultarPorNome(txtPesquisar.Text);
                dgvConsultaCRUD.DataSource = colaboradorColecao;               

                dgvConsultaCRUD.Update();
                dgvConsultaCRUD.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            //Controle de Botoes e Tela
            grbPrincipal.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditarCliente.Enabled = false;
            btnNovoCliente.Enabled = false;
            txtNomeCliente.Focus();
            grpConsulta.Enabled = false;
            dgvConsultaCRUD.Enabled = false;
            limparCampos();
            cbbStatus.Text = "ATIVO";
            EnrollDig = "";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verifica se está em modo de alteração ou inserção
            if (string.Compare(grbPrincipal.Text, "Dados do Médico", true) == 0)
            {
                try
                {
                    if ((String.Compare(txtNomeCliente.Text, "", true) != 0)&&(String.Compare(txtCrmUf.Text, "", true) != 0)&&(String.Compare(txtCrm.Text, "", true) != 0)&&(String.Compare(txtCelularCliente.Text, "(  )      -", true) != 0))
                    {
                        Colaborador cliente = new Colaborador();

                        cliente.Bairro = txtBairroCliente.Text;
                        cliente.Celular = txtCelularCliente.Text;
                        cliente.Cep = txtCepCliente.Text;
                        cliente.Cidade = txtCidadeCliente.Text;
                        cliente.TelContato = txtContatoCliente.Text;
                        cliente.Email = txtEmailCliente.Text;
                        cliente.Uf = txtEstadoCliente.Text;
                        cliente.TelFixo = txtTelFixoCliente.Text;
                        cliente.Rua = txtRuaCliente.Text;
                        cliente.Nome = txtNomeCliente.Text;
                        cliente.Crm = txtCrm.Text;
                        cliente.CrmUf = txtCrmUf.Text;
                        cliente.Digital = EnrollDig;
                        cliente.Status = cbbStatus.Text;

                        //Insere a foto no campo Byte[]
                        if (picFoto.Image != null)
                        {
                            try
                            {
                                MemoryStream memory = new MemoryStream();
                                bmp.Save(memory, ImageFormat.Bmp);
                                cliente.Foto = memory.ToArray();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Erro ao inserir a foto. Detalhes:" + ex.Message);
                            }
                        }
                        else
                        {
                            Bitmap imagemInicial = new Bitmap(Application.StartupPath + ("\\sem-foto.jpg"));
                            bmp = imagemInicial;
                            MemoryStream memory = new MemoryStream();
                            imagemInicial.Save(memory, ImageFormat.Bmp);
                            cliente.Foto = memory.ToArray();
                        }                        
                        //Termina a insercao da foto

                        ColaboradorNegocio negocio = new ColaboradorNegocio();
                        String retorno = negocio.Inserir(cliente);

                        //Controle de Botoes e Tela
                        grbPrincipal.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnEditarCliente.Enabled = false;
                        limparCampos();
                        btnNovoCliente.Enabled = true;
                        grpConsulta.Enabled = true;
                        dgvConsultaCRUD.Enabled = true;

                        if (retorno.Length > 7)
                        {
                            MessageBox.Show("Erro ao inserir Médico: " + retorno);
                        }
                        else
                        {
                            MessageBox.Show("Médico inserido com sucesso. ID: " + retorno);
                        }
                                               

                        
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir Médico. Verifique se os campos obrigatórios marcados com (*) estão preenchidos.");
                        return;
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    if ((String.Compare(txtNomeCliente.Text, "", true) != 0) && (String.Compare(txtCrmUf.Text, "", true) != 0) && (String.Compare(txtCrm.Text, "", true) != 0) && (String.Compare(txtCelularCliente.Text, "(  )      -", true) != 0))
                    {
                        Colaborador cliente = new Colaborador();

                        cliente.Bairro = txtBairroCliente.Text;
                        cliente.Celular = txtCelularCliente.Text;
                        cliente.Cep = txtCepCliente.Text;
                        cliente.Cidade = txtCidadeCliente.Text;
                        cliente.TelContato = txtContatoCliente.Text;
                        cliente.Email = txtEmailCliente.Text;
                        cliente.Uf = txtEstadoCliente.Text;
                        cliente.TelFixo = txtTelFixoCliente.Text;
                        cliente.Rua = txtRuaCliente.Text;
                        cliente.Nome = txtNomeCliente.Text;
                        cliente.Crm = txtCrm.Text;
                        cliente.CrmUf = txtCrmUf.Text;
                        cliente.Digital = EnrollDig;
                        cliente.Status = cbbStatus.Text;
                        cliente.Id = int.Parse(txtId.Text);

                        //Insere a foto no campo Byte[]
                        if (picFoto.Image != null)
                        {
                            try
                            {
                                MemoryStream memory = new MemoryStream();
                                bmp.Save(memory, ImageFormat.Bmp);
                                cliente.Foto = memory.ToArray();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("Erro ao inserir a foto. Detalhes:" + ex.Message);
       
                            }
                        }
                        else
                        {
                            cliente.Foto = null;
                        }
                        //Termina a insercao da foto

                        ColaboradorNegocio negocio = new ColaboradorNegocio();
                        String retorno = negocio.Alterar(cliente);

                        MessageBox.Show("Médico alterado com sucesso. ID: " + retorno);

                        //Controle de Botoes e Tela
                        //Controle de Botoes e Tela
                        grbPrincipal.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnEditarCliente.Enabled = false;
                        btnNovoCliente.Enabled = true;
                        grpConsulta.Enabled = true;
                        dgvConsultaCRUD.Enabled = true;
                        atualizaGrid();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar Médico. Verifique se os campos obrigatórios estão preenchidos.");
                        //Controle de Botoes e Tela
                        grbPrincipal.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnEditarCliente.Enabled = false;
                        limparCampos();
                        btnNovoCliente.Enabled = true;
                        grpConsulta.Enabled = true;
                        dgvConsultaCRUD.Enabled = true;
                        return;
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            grbPrincipal.Enabled = true;
            cbbStatus.ReadOnly = false;
            grbPrincipal.Text = "Dados do Médico*";
            btnNovoCliente.Enabled = false;
            grpConsulta.Enabled = false;
            dgvConsultaCRUD.Enabled = false;
            btnEditarCliente.Enabled = false;
        }

        private void FrmCadastroMedicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControleFormulario.frmCadastroMedicos = null;
        }

        private void btnCadastrarDigital_Click(object sender, EventArgs e)
        {
            

            LeitorBiometrico leitor = new LeitorBiometrico();

            EnrollDig = leitor.Enroll();            

            if (EnrollDig == "")
            {
                MessageBox.Show("Erro ao capturar o byte do Enroll");
            }

            leitor = null;
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                atualizaGrid();
                dgvConsultaCRUD.Focus();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void dgvConsultaCRUD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            preencherColaborador();
        }

        private void dgvConsultaCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            preencherColaborador();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            LeitorBiometrico leitor = new LeitorBiometrico();
            NBioAPI.Type.HFIR teste = leitor.Capturar();
            NBioAPI.Type.FIR_TEXTENCODE teste2;
            NBioAPI m_NBioAPI = new NBioAPI();
            m_NBioAPI.GetTextFIRFromHandle(teste, out teste2, true);
            string teste3 = teste2.TextFIR;
            MessageBox.Show(teste3);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                String foto = openFile.FileName;
                bmp = new Bitmap(foto);
                picFoto.Image = bmp;            
            }
        }
    }
}
