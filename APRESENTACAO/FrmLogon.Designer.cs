#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace APRESENTACAO
{
    partial class FrmLogon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSenha = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnCancelar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnEntrar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtUsuario = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblLogin = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblSenha = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.imgLogon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.BeforeTouchSize = new System.Drawing.Size(161, 20);
            this.txtSenha.Location = new System.Drawing.Point(136, 105);
            this.txtSenha.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(161, 20);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.ThemesEnabled = false;
            this.txtSenha.UseBorderColorOnFocus = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCancelar.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IsBackStageButton = false;
            this.btnCancelar.Location = new System.Drawing.Point(161, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyle = true;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnEntrar.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.IsBackStageButton = false;
            this.btnEntrar.Location = new System.Drawing.Point(62, 133);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 13;
            this.btnEntrar.Text = "&Entrar";
            this.btnEntrar.UseVisualStyle = true;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BeforeTouchSize = new System.Drawing.Size(161, 20);
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(136, 34);
            this.txtUsuario.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(161, 20);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.ThemesEnabled = false;
            this.txtUsuario.UseBorderColorOnFocus = true;
            // 
            // lblLogin
            // 
            this.lblLogin.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblLogin.BeforeTouchSize = new System.Drawing.Size(161, 23);
            this.lblLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblLogin.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblLogin.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblLogin.Location = new System.Drawing.Point(136, 11);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(161, 23);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Usuário";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSenha
            // 
            this.lblSenha.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))), System.Drawing.Color.White);
            this.lblSenha.BeforeTouchSize = new System.Drawing.Size(161, 23);
            this.lblSenha.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblSenha.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblSenha.Location = new System.Drawing.Point(136, 82);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(161, 23);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogon
            // 
            this.imgLogon.Image = global::APRESENTACAO.Properties.Resources.Login_icon;
            this.imgLogon.Location = new System.Drawing.Point(2, 11);
            this.imgLogon.Name = "imgLogon";
            this.imgLogon.Size = new System.Drawing.Size(128, 114);
            this.imgLogon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogon.TabIndex = 12;
            this.imgLogon.TabStop = false;
            // 
            // FrmLogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 156);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.imgLogon);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSenha);
            this.Name = "FrmLogon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Ponto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogon_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogon_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogon_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSenha;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancelar;
        private Syncfusion.Windows.Forms.ButtonAdv btnEntrar;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsuario;
        private System.Windows.Forms.PictureBox imgLogon;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblLogin;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblSenha;
    }
}