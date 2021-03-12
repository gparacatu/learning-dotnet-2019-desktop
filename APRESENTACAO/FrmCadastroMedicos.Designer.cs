#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace APRESENTACAO
{
    partial class FrmCadastroMedicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblobservacao = new System.Windows.Forms.Label();
            this.grbPrincipal = new System.Windows.Forms.GroupBox();
            this.btnFoto = new Syncfusion.Windows.Forms.ButtonAdv();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbbStatus = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrarDigital = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtCrmUf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataNascimentoCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtEstadoCliente = new System.Windows.Forms.TextBox();
            this.txtCelularCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtContatoCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtTelFixoCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtCepCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.txtRuaCliente = new System.Windows.Forms.TextBox();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblTipoPesquisa = new System.Windows.Forms.Label();
            this.dgvConsultaCRUD = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnExcluirCliente = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnEditarCliente = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCancelarCliente = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnNovoCliente = new Syncfusion.Windows.Forms.ButtonAdv();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.grbPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).BeginInit();
            this.grpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblobservacao
            // 
            this.lblobservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblobservacao.AutoSize = true;
            this.lblobservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobservacao.ForeColor = System.Drawing.Color.DarkRed;
            this.lblobservacao.Location = new System.Drawing.Point(5, 414);
            this.lblobservacao.Name = "lblobservacao";
            this.lblobservacao.Size = new System.Drawing.Size(299, 13);
            this.lblobservacao.TabIndex = 8;
            this.lblobservacao.Text = "Obs.: Os campos marcados com *  são obrigatórios.";
            // 
            // grbPrincipal
            // 
            this.grbPrincipal.BackColor = System.Drawing.Color.White;
            this.grbPrincipal.Controls.Add(this.btnFoto);
            this.grbPrincipal.Controls.Add(this.picFoto);
            this.grbPrincipal.Controls.Add(this.txtId);
            this.grbPrincipal.Controls.Add(this.cbbStatus);
            this.grbPrincipal.Controls.Add(this.label3);
            this.grbPrincipal.Controls.Add(this.btnCadastrarDigital);
            this.grbPrincipal.Controls.Add(this.txtCrmUf);
            this.grbPrincipal.Controls.Add(this.label2);
            this.grbPrincipal.Controls.Add(this.txtDataNascimentoCliente);
            this.grbPrincipal.Controls.Add(this.txtEstadoCliente);
            this.grbPrincipal.Controls.Add(this.txtCelularCliente);
            this.grbPrincipal.Controls.Add(this.txtContatoCliente);
            this.grbPrincipal.Controls.Add(this.txtTelFixoCliente);
            this.grbPrincipal.Controls.Add(this.txtCepCliente);
            this.grbPrincipal.Controls.Add(this.txtEmailCliente);
            this.grbPrincipal.Controls.Add(this.txtCidadeCliente);
            this.grbPrincipal.Controls.Add(this.txtBairroCliente);
            this.grbPrincipal.Controls.Add(this.txtRuaCliente);
            this.grbPrincipal.Controls.Add(this.txtCrm);
            this.grbPrincipal.Controls.Add(this.txtNomeCliente);
            this.grbPrincipal.Controls.Add(this.label33);
            this.grbPrincipal.Controls.Add(this.label34);
            this.grbPrincipal.Controls.Add(this.label35);
            this.grbPrincipal.Controls.Add(this.label36);
            this.grbPrincipal.Controls.Add(this.label38);
            this.grbPrincipal.Controls.Add(this.label39);
            this.grbPrincipal.Controls.Add(this.label40);
            this.grbPrincipal.Controls.Add(this.label41);
            this.grbPrincipal.Controls.Add(this.label42);
            this.grbPrincipal.Controls.Add(this.label43);
            this.grbPrincipal.Controls.Add(this.label45);
            this.grbPrincipal.Controls.Add(this.label48);
            this.grbPrincipal.Enabled = false;
            this.grbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPrincipal.Location = new System.Drawing.Point(11, 11);
            this.grbPrincipal.Name = "grbPrincipal";
            this.grbPrincipal.Size = new System.Drawing.Size(536, 340);
            this.grbPrincipal.TabIndex = 0;
            this.grbPrincipal.TabStop = false;
            this.grbPrincipal.Text = "Dados do Médico";
            // 
            // btnFoto
            // 
            this.btnFoto.BeforeTouchSize = new System.Drawing.Size(105, 19);
            this.btnFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.IsBackStageButton = false;
            this.btnFoto.Location = new System.Drawing.Point(425, 73);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(105, 19);
            this.btnFoto.TabIndex = 32;
            this.btnFoto.Text = "Selecionar Foto";
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Image = global::APRESENTACAO.Properties.Resources.sem_foto;
            this.picFoto.Location = new System.Drawing.Point(425, 93);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(105, 74);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 31;
            this.picFoto.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(230, 19);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 20);
            this.txtId.TabIndex = 2;
            this.txtId.Visible = false;
            // 
            // cbbStatus
            // 
            this.cbbStatus.BackColor = System.Drawing.Color.White;
            this.cbbStatus.BeforeTouchSize = new System.Drawing.Size(105, 21);
            this.cbbStatus.FlatBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbbStatus.Location = new System.Drawing.Point(425, 42);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.ReadOnly = true;
            this.cbbStatus.Size = new System.Drawing.Size(105, 21);
            this.cbbStatus.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.cbbStatus.TabIndex = 6;
            this.cbbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(422, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // btnCadastrarDigital
            // 
            this.btnCadastrarDigital.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP;
            this.btnCadastrarDigital.BackColor = System.Drawing.Color.White;
            this.btnCadastrarDigital.BeforeTouchSize = new System.Drawing.Size(112, 95);
            this.btnCadastrarDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarDigital.Image = global::APRESENTACAO.Properties.Resources.digital32x32;
            this.btnCadastrarDigital.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarDigital.IsBackStageButton = false;
            this.btnCadastrarDigital.Location = new System.Drawing.Point(418, 230);
            this.btnCadastrarDigital.MetroColor = System.Drawing.Color.White;
            this.btnCadastrarDigital.Name = "btnCadastrarDigital";
            this.btnCadastrarDigital.Size = new System.Drawing.Size(112, 95);
            this.btnCadastrarDigital.TabIndex = 29;
            this.btnCadastrarDigital.Text = "Cadastrar Digital";
            this.btnCadastrarDigital.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarDigital.Click += new System.EventHandler(this.btnCadastrarDigital_Click);
            // 
            // txtCrmUf
            // 
            this.txtCrmUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCrmUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrmUf.ForeColor = System.Drawing.Color.Black;
            this.txtCrmUf.Location = new System.Drawing.Point(171, 93);
            this.txtCrmUf.MaxLength = 50;
            this.txtCrmUf.Name = "txtCrmUf";
            this.txtCrmUf.Size = new System.Drawing.Size(128, 20);
            this.txtCrmUf.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(168, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CRM UF*";
            // 
            // txtDataNascimentoCliente
            // 
            this.txtDataNascimentoCliente.Enabled = false;
            this.txtDataNascimentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimentoCliente.ForeColor = System.Drawing.Color.Black;
            this.txtDataNascimentoCliente.Location = new System.Drawing.Point(305, 42);
            this.txtDataNascimentoCliente.Mask = "00/00/0000";
            this.txtDataNascimentoCliente.Name = "txtDataNascimentoCliente";
            this.txtDataNascimentoCliente.Size = new System.Drawing.Size(104, 20);
            this.txtDataNascimentoCliente.TabIndex = 4;
            this.txtDataNascimentoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataNascimentoCliente.ValidatingType = typeof(System.DateTime);
            // 
            // txtEstadoCliente
            // 
            this.txtEstadoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoCliente.ForeColor = System.Drawing.Color.Black;
            this.txtEstadoCliente.Location = new System.Drawing.Point(418, 199);
            this.txtEstadoCliente.MaxLength = 50;
            this.txtEstadoCliente.Name = "txtEstadoCliente";
            this.txtEstadoCliente.Size = new System.Drawing.Size(112, 20);
            this.txtEstadoCliente.TabIndex = 20;
            // 
            // txtCelularCliente
            // 
            this.txtCelularCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularCliente.Location = new System.Drawing.Point(306, 305);
            this.txtCelularCliente.Mask = "(99) 00000-0000";
            this.txtCelularCliente.Name = "txtCelularCliente";
            this.txtCelularCliente.Size = new System.Drawing.Size(103, 20);
            this.txtCelularCliente.TabIndex = 28;
            this.txtCelularCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContatoCliente
            // 
            this.txtContatoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoCliente.Location = new System.Drawing.Point(156, 305);
            this.txtContatoCliente.Mask = "(99) 00000-0000";
            this.txtContatoCliente.Name = "txtContatoCliente";
            this.txtContatoCliente.Size = new System.Drawing.Size(94, 20);
            this.txtContatoCliente.TabIndex = 26;
            this.txtContatoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelFixoCliente
            // 
            this.txtTelFixoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelFixoCliente.Location = new System.Drawing.Point(6, 305);
            this.txtTelFixoCliente.Mask = "(99) 0000-0000";
            this.txtTelFixoCliente.Name = "txtTelFixoCliente";
            this.txtTelFixoCliente.Size = new System.Drawing.Size(94, 20);
            this.txtTelFixoCliente.TabIndex = 24;
            this.txtTelFixoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCepCliente
            // 
            this.txtCepCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCepCliente.Location = new System.Drawing.Point(315, 93);
            this.txtCepCliente.Mask = "00000-000";
            this.txtCepCliente.Name = "txtCepCliente";
            this.txtCepCliente.Size = new System.Drawing.Size(94, 20);
            this.txtCepCliente.TabIndex = 12;
            this.txtCepCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.ForeColor = System.Drawing.Color.Black;
            this.txtEmailCliente.Location = new System.Drawing.Point(6, 250);
            this.txtEmailCliente.MaxLength = 50;
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(403, 20);
            this.txtEmailCliente.TabIndex = 22;
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidadeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCidadeCliente.Location = new System.Drawing.Point(191, 199);
            this.txtCidadeCliente.MaxLength = 50;
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(219, 20);
            this.txtCidadeCliente.TabIndex = 18;
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroCliente.ForeColor = System.Drawing.Color.Black;
            this.txtBairroCliente.Location = new System.Drawing.Point(5, 199);
            this.txtBairroCliente.MaxLength = 50;
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(178, 20);
            this.txtBairroCliente.TabIndex = 16;
            // 
            // txtRuaCliente
            // 
            this.txtRuaCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRuaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuaCliente.ForeColor = System.Drawing.Color.Black;
            this.txtRuaCliente.Location = new System.Drawing.Point(7, 147);
            this.txtRuaCliente.MaxLength = 50;
            this.txtRuaCliente.Name = "txtRuaCliente";
            this.txtRuaCliente.Size = new System.Drawing.Size(402, 20);
            this.txtRuaCliente.TabIndex = 14;
            // 
            // txtCrm
            // 
            this.txtCrm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrm.ForeColor = System.Drawing.Color.Black;
            this.txtCrm.Location = new System.Drawing.Point(6, 93);
            this.txtCrm.MaxLength = 50;
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(149, 20);
            this.txtCrm.TabIndex = 8;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCliente.Location = new System.Drawing.Point(6, 42);
            this.txtNomeCliente.MaxLength = 50;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(283, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(2, 179);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(34, 13);
            this.label33.TabIndex = 15;
            this.label33.Text = "Bairro";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(153, 285);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(44, 13);
            this.label34.TabIndex = 25;
            this.label34.Text = "Contato";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.DarkRed;
            this.label35.Location = new System.Drawing.Point(303, 285);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(51, 13);
            this.label35.TabIndex = 27;
            this.label35.Text = "Celular*";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(2, 285);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(71, 13);
            this.label36.TabIndex = 23;
            this.label36.Text = "Telefone Fixo";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(414, 179);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(40, 13);
            this.label38.TabIndex = 19;
            this.label38.Text = "Estado";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(189, 179);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(40, 13);
            this.label39.TabIndex = 17;
            this.label39.Text = "Cidade";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(312, 73);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(26, 13);
            this.label40.TabIndex = 11;
            this.label40.Text = "Cep";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(3, 127);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(70, 13);
            this.label41.TabIndex = 13;
            this.label41.Text = "Rua, Número";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(2, 230);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(35, 13);
            this.label42.TabIndex = 21;
            this.label42.Text = "E-mail";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(302, 22);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(75, 13);
            this.label43.TabIndex = 3;
            this.label43.Text = "Data Cadastro";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.DarkRed;
            this.label45.Location = new System.Drawing.Point(2, 73);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(39, 13);
            this.label45.TabIndex = 7;
            this.label45.Text = "CRM*";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.DarkRed;
            this.label48.Location = new System.Drawing.Point(2, 22);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(44, 13);
            this.label48.TabIndex = 0;
            this.label48.Text = "Nome*";
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnPesquisar);
            this.grpConsulta.Controls.Add(this.txtPesquisar);
            this.grpConsulta.Controls.Add(this.lblTipoPesquisa);
            this.grpConsulta.Location = new System.Drawing.Point(553, 11);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(453, 42);
            this.grpConsulta.TabIndex = 1;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Pesquisa de Médicos";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.Location = new System.Drawing.Point(367, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(84, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(44, 21);
            this.txtPesquisar.MaxLength = 50;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(323, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // lblTipoPesquisa
            // 
            this.lblTipoPesquisa.AutoSize = true;
            this.lblTipoPesquisa.Location = new System.Drawing.Point(8, 24);
            this.lblTipoPesquisa.Name = "lblTipoPesquisa";
            this.lblTipoPesquisa.Size = new System.Drawing.Size(38, 13);
            this.lblTipoPesquisa.TabIndex = 0;
            this.lblTipoPesquisa.Text = "Nome:";
            // 
            // dgvConsultaCRUD
            // 
            this.dgvConsultaCRUD.AllowUserToAddRows = false;
            this.dgvConsultaCRUD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvConsultaCRUD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaCRUD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultaCRUD.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaCRUD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultaCRUD.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvConsultaCRUD.Location = new System.Drawing.Point(553, 55);
            this.dgvConsultaCRUD.MultiSelect = false;
            this.dgvConsultaCRUD.Name = "dgvConsultaCRUD";
            this.dgvConsultaCRUD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvConsultaCRUD.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsultaCRUD.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvConsultaCRUD.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConsultaCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaCRUD.Size = new System.Drawing.Size(453, 371);
            this.dgvConsultaCRUD.TabIndex = 2;
            this.dgvConsultaCRUD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaCRUD_CellClick);
            this.dgvConsultaCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaCRUD_CellDoubleClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.BeforeTouchSize = new System.Drawing.Size(75, 55);
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::APRESENTACAO.Properties.Resources.Sign_Select_icon__3_;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.IsBackStageButton = false;
            this.btnSalvar.Location = new System.Drawing.Point(126, 353);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 55);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirCliente.BeforeTouchSize = new System.Drawing.Size(75, 55);
            this.btnExcluirCliente.Enabled = false;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCliente.Image = global::APRESENTACAO.Properties.Resources.Places_trash_full_icon32;
            this.btnExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirCliente.IsBackStageButton = false;
            this.btnExcluirCliente.Location = new System.Drawing.Point(473, 352);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(75, 55);
            this.btnExcluirCliente.TabIndex = 7;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarCliente.BeforeTouchSize = new System.Drawing.Size(75, 55);
            this.btnEditarCliente.Enabled = false;
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.Image = global::APRESENTACAO.Properties.Resources.Applications_Folder_white_icon32;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarCliente.IsBackStageButton = false;
            this.btnEditarCliente.Location = new System.Drawing.Point(356, 353);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(75, 55);
            this.btnEditarCliente.TabIndex = 6;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarCliente.BeforeTouchSize = new System.Drawing.Size(75, 55);
            this.btnCancelarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCliente.Image = global::APRESENTACAO.Properties.Resources.Alarm_Error_icon__3_;
            this.btnCancelarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarCliente.IsBackStageButton = false;
            this.btnCancelarCliente.Location = new System.Drawing.Point(241, 353);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(75, 55);
            this.btnCancelarCliente.TabIndex = 5;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovoCliente.BeforeTouchSize = new System.Drawing.Size(75, 55);
            this.btnNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.Image = global::APRESENTACAO.Properties.Resources.New_Folder_black_icon32;
            this.btnNovoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoCliente.IsBackStageButton = false;
            this.btnNovoCliente.Location = new System.Drawing.Point(11, 352);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(75, 55);
            this.btnNovoCliente.TabIndex = 3;
            this.btnNovoCliente.Text = "Novo";
            this.btnNovoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // openFile
            // 
            this.openFile.Filter = "|*.jpg";
            // 
            // FrmCadastroMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 426);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.dgvConsultaCRUD);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnCancelarCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.lblobservacao);
            this.Controls.Add(this.grbPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmCadastroMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Médicos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadastroMedicos_FormClosed);
            this.grbPrincipal.ResumeLayout(false);
            this.grbPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbStatus)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCRUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnSalvar;
        private Syncfusion.Windows.Forms.ButtonAdv btnExcluirCliente;
        private Syncfusion.Windows.Forms.ButtonAdv btnEditarCliente;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancelarCliente;
        private Syncfusion.Windows.Forms.ButtonAdv btnNovoCliente;
        private System.Windows.Forms.Label lblobservacao;
        private System.Windows.Forms.GroupBox grbPrincipal;
        private System.Windows.Forms.MaskedTextBox txtDataNascimentoCliente;
        private System.Windows.Forms.TextBox txtEstadoCliente;
        private System.Windows.Forms.MaskedTextBox txtCelularCliente;
        private System.Windows.Forms.MaskedTextBox txtContatoCliente;
        private System.Windows.Forms.MaskedTextBox txtTelFixoCliente;
        private System.Windows.Forms.MaskedTextBox txtCepCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.TextBox txtRuaCliente;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txtCrmUf;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.ButtonAdv btnCadastrarDigital;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbbStatus;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblTipoPesquisa;
        private System.Windows.Forms.DataGridView dgvConsultaCRUD;
        private System.Windows.Forms.TextBox txtId;
        private Syncfusion.Windows.Forms.ButtonAdv btnFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}