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
using NEGOCIO;
using TRANSFERENCIA;
using System.Text;
using System.Windows.Forms;

namespace APRESENTACAO
{
    public partial class FrmLogon : Syncfusion.Windows.Forms.MetroForm
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void Entrar()
        {
            try
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                Usuario usuarioLogado = new Usuario();
                usuarioLogado = usuarioNegocio.ConsultarPorUsuarioSenha(txtUsuario.Text, txtSenha.Text);
                this.Visible = false;
                ControleFormulario.abreFrmMenu();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Usuário ou senha não confere! Erro: "+ex.Message);
            }




        }

        private void FrmLogon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ControleFormulario.frmLogon != null)
                ControleFormulario.frmLogon = null;
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entrar();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void FrmLogon_Load(object sender, EventArgs e)
        {
            
        }
    }
}
