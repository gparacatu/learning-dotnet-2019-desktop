#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace APRESENTACAO
{
    partial class FrmRelatorioPontoGeral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gradientLabel4 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.dtpFinalGeral = new System.Windows.Forms.DateTimePicker();
            this.dtpInicialGeral = new System.Windows.Forms.DateTimePicker();
            this.lblDatas = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblDescricao = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.btnGerar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel3 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblTipoPesquisa = new System.Windows.Forms.Label();
            this.dgvConsultaCRUD = new System.Windows.Forms.DataGridView();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.dtpFinalMedico = new System.Windows.Forms.DateTimePicker();
            this.dtpInicialMedico = new System.Windows.Forms.DateTimePicker();
            this.btnGerarRelatorioMedico = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnSair = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(16, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 386);
            this.tabControl1.TabIndex = 44;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSair);
            this.tabPage1.Controls.Add(this.gradientLabel4);
            this.tabPage1.Controls.Add(this.dtpFinalGeral);
            this.tabPage1.Controls.Add(this.dtpInicialGeral);
            this.tabPage1.Controls.Add(this.lblDatas);
            this.tabPage1.Controls.Add(this.lblDescricao);
            this.tabPage1.Controls.Add(this.btnGerar);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ponto - Geral";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAdv1);
            this.tabPage2.Controls.Add(this.btnGerarRelatorioMedico);
            this.tabPage2.Controls.Add(this.gradientLabel1);
            this.tabPage2.Controls.Add(this.gradientLabel3);
            this.tabPage2.Controls.Add(this.grpConsulta);
            this.tabPage2.Controls.Add(this.dgvConsultaCRUD);
            this.tabPage2.Controls.Add(this.gradientLabel2);
            this.tabPage2.Controls.Add(this.dtpFinalMedico);
            this.tabPage2.Controls.Add(this.dtpInicialMedico);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ponto - Médico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.gradientLabel4.BeforeTouchSize = new System.Drawing.Size(92, 26);
            this.gradientLabel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel4.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel4.ForeColor = System.Drawing.Color.White;
            this.gradientLabel4.Location = new System.Drawing.Point(47, 116);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(92, 26);
            this.gradientLabel4.TabIndex = 43;
            this.gradientLabel4.Text = "Data Final:";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFinalGeral
            // 
            this.dtpFinalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinalGeral.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinalGeral.Location = new System.Drawing.Point(145, 116);
            this.dtpFinalGeral.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFinalGeral.Name = "dtpFinalGeral";
            this.dtpFinalGeral.Size = new System.Drawing.Size(250, 26);
            this.dtpFinalGeral.TabIndex = 42;
            // 
            // dtpInicialGeral
            // 
            this.dtpInicialGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicialGeral.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicialGeral.Location = new System.Drawing.Point(145, 61);
            this.dtpInicialGeral.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpInicialGeral.Name = "dtpInicialGeral";
            this.dtpInicialGeral.Size = new System.Drawing.Size(250, 26);
            this.dtpInicialGeral.TabIndex = 41;
            // 
            // lblDatas
            // 
            this.lblDatas.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.lblDatas.BeforeTouchSize = new System.Drawing.Size(92, 26);
            this.lblDatas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblDatas.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblDatas.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatas.ForeColor = System.Drawing.Color.White;
            this.lblDatas.Location = new System.Drawing.Point(47, 61);
            this.lblDatas.Name = "lblDatas";
            this.lblDatas.Size = new System.Drawing.Size(92, 26);
            this.lblDatas.TabIndex = 39;
            this.lblDatas.Text = "Data Inicial:";
            this.lblDatas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.lblDescricao.BeforeTouchSize = new System.Drawing.Size(436, 38);
            this.lblDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.lblDescricao.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblDescricao.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(436, 38);
            this.lblDescricao.TabIndex = 38;
            this.lblDescricao.Text = "Relatório de Ponto - Geral";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGerar.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGerar.BeforeTouchSize = new System.Drawing.Size(436, 30);
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.IsBackStageButton = false;
            this.btnGerar.Location = new System.Drawing.Point(0, 285);
            this.btnGerar.MetroColor = System.Drawing.Color.Maroon;
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(436, 30);
            this.btnGerar.TabIndex = 40;
            this.btnGerar.Text = "&Gerar Relatório - Geral";
            this.btnGerar.UseVisualStyle = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(92, 26);
            this.gradientLabel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.ForeColor = System.Drawing.Color.White;
            this.gradientLabel1.Location = new System.Drawing.Point(47, 116);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(92, 26);
            this.gradientLabel1.TabIndex = 51;
            this.gradientLabel1.Text = "Data Final:";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218))))));
            this.gradientLabel3.BeforeTouchSize = new System.Drawing.Size(92, 26);
            this.gradientLabel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel3.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel3.ForeColor = System.Drawing.Color.White;
            this.gradientLabel3.Location = new System.Drawing.Point(47, 61);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(92, 26);
            this.gradientLabel3.TabIndex = 50;
            this.gradientLabel3.Text = "Data Inicial:";
            this.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnPesquisar);
            this.grpConsulta.Controls.Add(this.txtPesquisar);
            this.grpConsulta.Controls.Add(this.lblTipoPesquisa);
            this.grpConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsulta.Location = new System.Drawing.Point(5, 148);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(426, 59);
            this.grpConsulta.TabIndex = 48;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Pesquisa de Médicos";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.Image = global::APRESENTACAO.Properties.Resources.Zoom_icon__4_;
            this.btnPesquisar.Location = new System.Drawing.Point(371, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(46, 33);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(66, 22);
            this.txtPesquisar.MaxLength = 50;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(301, 23);
            this.txtPesquisar.TabIndex = 1;
            // 
            // lblTipoPesquisa
            // 
            this.lblTipoPesquisa.AutoSize = true;
            this.lblTipoPesquisa.Location = new System.Drawing.Point(6, 26);
            this.lblTipoPesquisa.Name = "lblTipoPesquisa";
            this.lblTipoPesquisa.Size = new System.Drawing.Size(54, 17);
            this.lblTipoPesquisa.TabIndex = 0;
            this.lblTipoPesquisa.Text = "Nome:";
            // 
            // dgvConsultaCRUD
            // 
            this.dgvConsultaCRUD.AllowUserToAddRows = false;
            this.dgvConsultaCRUD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            this.dgvConsultaCRUD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvConsultaCRUD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultaCRUD.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvConsultaCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaCRUD.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvConsultaCRUD.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvConsultaCRUD.Location = new System.Drawing.Point(5, 210);
            this.dgvConsultaCRUD.MultiSelect = false;
            this.dgvConsultaCRUD.Name = "dgvConsultaCRUD";
            this.dgvConsultaCRUD.ReadOnly = true;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            this.dgvConsultaCRUD.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvConsultaCRUD.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvConsultaCRUD.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvConsultaCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaCRUD.Size = new System.Drawing.Size(426, 72);
            this.dgvConsultaCRUD.TabIndex = 49;
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Black);
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(436, 38);
            this.gradientLabel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gradientLabel2.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel2.ForeColor = System.Drawing.Color.White;
            this.gradientLabel2.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(436, 38);
            this.gradientLabel2.TabIndex = 46;
            this.gradientLabel2.Text = " Relatório de Ponto - Médico";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFinalMedico
            // 
            this.dtpFinalMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinalMedico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinalMedico.Location = new System.Drawing.Point(145, 116);
            this.dtpFinalMedico.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFinalMedico.Name = "dtpFinalMedico";
            this.dtpFinalMedico.Size = new System.Drawing.Size(250, 26);
            this.dtpFinalMedico.TabIndex = 45;
            // 
            // dtpInicialMedico
            // 
            this.dtpInicialMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicialMedico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicialMedico.Location = new System.Drawing.Point(145, 61);
            this.dtpInicialMedico.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpInicialMedico.Name = "dtpInicialMedico";
            this.dtpInicialMedico.Size = new System.Drawing.Size(250, 26);
            this.dtpInicialMedico.TabIndex = 44;
            // 
            // btnGerarRelatorioMedico
            // 
            this.btnGerarRelatorioMedico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGerarRelatorioMedico.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnGerarRelatorioMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnGerarRelatorioMedico.BeforeTouchSize = new System.Drawing.Size(436, 30);
            this.btnGerarRelatorioMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorioMedico.ForeColor = System.Drawing.Color.White;
            this.btnGerarRelatorioMedico.IsBackStageButton = false;
            this.btnGerarRelatorioMedico.Location = new System.Drawing.Point(0, 285);
            this.btnGerarRelatorioMedico.MetroColor = System.Drawing.Color.Maroon;
            this.btnGerarRelatorioMedico.Name = "btnGerarRelatorioMedico";
            this.btnGerarRelatorioMedico.Size = new System.Drawing.Size(436, 30);
            this.btnGerarRelatorioMedico.TabIndex = 52;
            this.btnGerarRelatorioMedico.Text = "&Gerar Relatório - Médico";
            this.btnGerarRelatorioMedico.UseVisualStyle = true;
            this.btnGerarRelatorioMedico.Click += new System.EventHandler(this.btnGerarRelatorioMedico_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnSair.BeforeTouchSize = new System.Drawing.Size(440, 33);
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.IsBackStageButton = false;
            this.btnSair.Location = new System.Drawing.Point(0, 316);
            this.btnSair.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(440, 33);
            this.btnSair.TabIndex = 44;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyle = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(440, 33);
            this.buttonAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(-2, 316);
            this.buttonAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(440, 33);
            this.buttonAdv1.TabIndex = 53;
            this.buttonAdv1.Text = "&Sair";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmRelatorioPontoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 397);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatorioPontoGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios de Ponto";
            this.Load += new System.EventHandler(this.FrmRelatorioPontoGeral_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCRUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel4;
        private System.Windows.Forms.DateTimePicker dtpFinalGeral;
        private System.Windows.Forms.DateTimePicker dtpInicialGeral;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblDatas;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblDescricao;
        private Syncfusion.Windows.Forms.ButtonAdv btnGerar;
        private System.Windows.Forms.TabPage tabPage2;
        private Syncfusion.Windows.Forms.ButtonAdv btnGerarRelatorioMedico;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel3;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblTipoPesquisa;
        private System.Windows.Forms.DataGridView dgvConsultaCRUD;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
        private System.Windows.Forms.DateTimePicker dtpFinalMedico;
        private System.Windows.Forms.DateTimePicker dtpInicialMedico;
        private Syncfusion.Windows.Forms.ButtonAdv btnSair;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
    }
}