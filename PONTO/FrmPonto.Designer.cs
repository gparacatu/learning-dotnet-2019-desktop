#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Ponto
{
    partial class FrmPonto
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
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer1 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer1 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPonto));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panDadosAcesso = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.lblPrincipal = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDataHoraEntrada = new System.Windows.Forms.Label();
            this.lblTempoTotal = new System.Windows.Forms.Label();
            this.lblTempoTotalLeitura = new System.Windows.Forms.Label();
            this.lblDataHoraSaida = new System.Windows.Forms.Label();
            this.lblDataHoraSaidaLeitura = new System.Windows.Forms.Label();
            this.lblDataHoraEntradaLeitura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCrm = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clock1 = new Syncfusion.Windows.Forms.Tools.Clock();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panDadosAcesso)).BeginInit();
            this.panDadosAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panDadosAcesso
            // 
            this.panDadosAcesso.BackColor = System.Drawing.Color.White;
            this.panDadosAcesso.Controls.Add(this.lblPrincipal);
            this.panDadosAcesso.Controls.Add(this.pictureBox1);
            this.panDadosAcesso.Controls.Add(this.lblDataHoraEntrada);
            this.panDadosAcesso.Controls.Add(this.lblTempoTotal);
            this.panDadosAcesso.Controls.Add(this.lblTempoTotalLeitura);
            this.panDadosAcesso.Controls.Add(this.lblDataHoraSaida);
            this.panDadosAcesso.Controls.Add(this.lblDataHoraSaidaLeitura);
            this.panDadosAcesso.Controls.Add(this.lblDataHoraEntradaLeitura);
            this.panDadosAcesso.Controls.Add(this.label3);
            this.panDadosAcesso.Controls.Add(this.lblCrm);
            this.panDadosAcesso.Controls.Add(this.lblNome);
            this.panDadosAcesso.Controls.Add(this.label2);
            this.panDadosAcesso.Location = new System.Drawing.Point(110, 35);
            this.panDadosAcesso.Name = "panDadosAcesso";
            this.panDadosAcesso.Size = new System.Drawing.Size(760, 423);
            this.panDadosAcesso.TabIndex = 17;
            this.panDadosAcesso.Visible = false;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Black, System.Drawing.Color.White);
            this.lblPrincipal.BeforeTouchSize = new System.Drawing.Size(763, 59);
            this.lblPrincipal.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblPrincipal.Location = new System.Drawing.Point(-3, -3);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(763, 59);
            this.lblPrincipal.TabIndex = 23;
            this.lblPrincipal.Text = "ENTRADA REGISTRADA COM SUCESSO. BOM SERVIÇO!";
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(569, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lblDataHoraEntrada
            // 
            this.lblDataHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHoraEntrada.Location = new System.Drawing.Point(314, 212);
            this.lblDataHoraEntrada.Name = "lblDataHoraEntrada";
            this.lblDataHoraEntrada.Size = new System.Drawing.Size(439, 54);
            this.lblDataHoraEntrada.TabIndex = 17;
            this.lblDataHoraEntrada.Text = "Data e Hora da Entrada:AAAAAAAAAA";
            this.lblDataHoraEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTempoTotal
            // 
            this.lblTempoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTempoTotal.Location = new System.Drawing.Point(290, 356);
            this.lblTempoTotal.Name = "lblTempoTotal";
            this.lblTempoTotal.Size = new System.Drawing.Size(422, 54);
            this.lblTempoTotal.TabIndex = 21;
            this.lblTempoTotal.Text = "Tempo Total:AAAAAAAAAAAAA";
            this.lblTempoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTempoTotal.Visible = false;
            // 
            // lblTempoTotalLeitura
            // 
            this.lblTempoTotalLeitura.AutoSize = true;
            this.lblTempoTotalLeitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoTotalLeitura.Location = new System.Drawing.Point(14, 371);
            this.lblTempoTotalLeitura.Name = "lblTempoTotalLeitura";
            this.lblTempoTotalLeitura.Size = new System.Drawing.Size(270, 24);
            this.lblTempoTotalLeitura.TabIndex = 20;
            this.lblTempoTotalLeitura.Text = "TEMPO TOTAL HH:MM:SS:";
            this.lblTempoTotalLeitura.Visible = false;
            // 
            // lblDataHoraSaida
            // 
            this.lblDataHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHoraSaida.Location = new System.Drawing.Point(276, 284);
            this.lblDataHoraSaida.Name = "lblDataHoraSaida";
            this.lblDataHoraSaida.Size = new System.Drawing.Size(476, 54);
            this.lblDataHoraSaida.TabIndex = 19;
            this.lblDataHoraSaida.Text = "Data e Hora da Saída:AAAAAAAAAAAA";
            this.lblDataHoraSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDataHoraSaida.Visible = false;
            // 
            // lblDataHoraSaidaLeitura
            // 
            this.lblDataHoraSaidaLeitura.AutoSize = true;
            this.lblDataHoraSaidaLeitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHoraSaidaLeitura.Location = new System.Drawing.Point(14, 299);
            this.lblDataHoraSaidaLeitura.Name = "lblDataHoraSaidaLeitura";
            this.lblDataHoraSaidaLeitura.Size = new System.Drawing.Size(256, 24);
            this.lblDataHoraSaidaLeitura.TabIndex = 18;
            this.lblDataHoraSaidaLeitura.Text = "DATA E HORA DA SAÍDA:";
            this.lblDataHoraSaidaLeitura.Visible = false;
            // 
            // lblDataHoraEntradaLeitura
            // 
            this.lblDataHoraEntradaLeitura.AutoSize = true;
            this.lblDataHoraEntradaLeitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHoraEntradaLeitura.Location = new System.Drawing.Point(14, 227);
            this.lblDataHoraEntradaLeitura.Name = "lblDataHoraEntradaLeitura";
            this.lblDataHoraEntradaLeitura.Size = new System.Drawing.Size(294, 24);
            this.lblDataHoraEntradaLeitura.TabIndex = 16;
            this.lblDataHoraEntradaLeitura.Text = "DATA E HORA DA ENTRADA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "CRM:";
            // 
            // lblCrm
            // 
            this.lblCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrm.Location = new System.Drawing.Point(81, 140);
            this.lblCrm.Name = "lblCrm";
            this.lblCrm.Size = new System.Drawing.Size(491, 54);
            this.lblCrm.TabIndex = 14;
            this.lblCrm.Text = "CRM:";
            this.lblCrm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(95, 68);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(477, 54);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "GUILHERME APARECIDO DE JESUS PARACATU";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "NOME:";
            // 
            // clock1
            // 
            this.clock1.BackgroundColor = System.Drawing.Color.Black;
            this.clock1.BeforeTouchSize = new System.Drawing.Size(980, 490);
            this.clock1.ClockFormat = "HH:mm:ss";
            this.clock1.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            this.clock1.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle;
            this.clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            this.clock1.CurrentDateTime = new System.DateTime(2018, 11, 2, 2, 16, 38, 214);
            this.clock1.CustomTime = new System.DateTime(2019, 1, 8, 2, 41, 28, 908);
            this.clock1.DigitalRenderer = digitalClockRenderer1;
            this.clock1.DisplayDates = true;
            this.clock1.ForeColor = System.Drawing.Color.White;
            this.clock1.Location = new System.Drawing.Point(0, 1);
            this.clock1.MinimumSize = new System.Drawing.Size(75, 75);
            this.clock1.Name = "clock1";
            this.clock1.Now = new System.DateTime(((long)(0)));
            this.clock1.Remainder = new System.DateTime(2018, 11, 2, 2, 16, 38, 213);
            this.clock1.Renderer = clockRenderer1;
            this.clock1.ShowAMorPM = true;
            this.clock1.ShowClockFrame = true;
            this.clock1.ShowCustomTimeClock = false;
            this.clock1.ShowHourDesignator = true;
            this.clock1.Size = new System.Drawing.Size(980, 490);
            this.clock1.StopTimer = false;
            this.clock1.TabIndex = 21;
            this.clock1.Text = "clock1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "PRESSIONE A TECLA (ENTER) PARA INSERIR A DIGITAL.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CaptionBarColor = System.Drawing.Color.LightSkyBlue;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 493);
            this.Controls.Add(this.panDadosAcesso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clock1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Ponto";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.FrmPonto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPonto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panDadosAcesso)).EndInit();
            this.panDadosAcesso.ResumeLayout(false);
            this.panDadosAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel panDadosAcesso;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDataHoraEntrada;
        private System.Windows.Forms.Label lblTempoTotal;
        private System.Windows.Forms.Label lblTempoTotalLeitura;
        private System.Windows.Forms.Label lblDataHoraSaida;
        private System.Windows.Forms.Label lblDataHoraSaidaLeitura;
        private System.Windows.Forms.Label lblDataHoraEntradaLeitura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCrm;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.Clock clock1;
        private System.Windows.Forms.Label label1;
    }
}