namespace APRESENTACAO
{
    partial class FrmPrincipal
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
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection1 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection1 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection1 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.clock1 = new Syncfusion.Windows.Forms.Tools.Clock();
            this.btnOnOff = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.btnCadastrarMedico = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pontosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarAdvPanel1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnOnOff)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // clock1
            // 
            this.clock1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.clock1.BeforeTouchSize = new System.Drawing.Size(154, 77);
            this.clock1.ClockFormat = "HH:mm:ss";
            this.clock1.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            this.clock1.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.RoundedRectangle;
            this.clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            this.clock1.CurrentDateTime = new System.DateTime(2018, 10, 30, 21, 21, 8, 360);
            this.clock1.CustomTime = new System.DateTime(2019, 1, 5, 5, 20, 26, 298);
            this.clock1.DigitalRenderer = digitalClockRenderer1;
            this.clock1.DisplayDates = true;
            this.clock1.ForeColor = System.Drawing.Color.White;
            this.clock1.Location = new System.Drawing.Point(870, 523);
            this.clock1.MinimumSize = new System.Drawing.Size(75, 75);
            this.clock1.Name = "clock1";
            this.clock1.Now = new System.DateTime(((long)(0)));
            this.clock1.Remainder = new System.DateTime(2018, 10, 30, 21, 21, 8, 346);
            this.clock1.Renderer = clockRenderer1;
            this.clock1.ShowClockFrame = true;
            this.clock1.ShowCustomTimeClock = false;
            this.clock1.ShowHourDesignator = false;
            this.clock1.Size = new System.Drawing.Size(154, 77);
            this.clock1.StopTimer = false;
            this.clock1.TabIndex = 1;
            this.clock1.Text = "clock1";
            // 
            // btnOnOff
            // 
            activeStateCollection1.Text = "FECHAR";
            this.btnOnOff.ActiveState = activeStateCollection1;
            this.btnOnOff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOnOff.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.btnOnOff.InactiveState = inactiveStateCollection1;
            this.btnOnOff.Location = new System.Drawing.Point(921, 0);
            this.btnOnOff.MinimumSize = new System.Drawing.Size(52, 20);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Renderer = toggleButtonRenderer1;
            this.btnOnOff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOnOff.Size = new System.Drawing.Size(103, 24);
            this.btnOnOff.Slider = sliderCollection1;
            this.btnOnOff.TabIndex = 2;
            this.btnOnOff.Text = "toggleButton1";
            this.btnOnOff.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            this.btnOnOff.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Default;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnCadastrarMedico
            // 
            this.btnCadastrarMedico.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCadastrarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnCadastrarMedico.BeforeTouchSize = new System.Drawing.Size(166, 155);
            this.btnCadastrarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMedico.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarMedico.Image = global::APRESENTACAO.Properties.Resources.Medicos166x120;
            this.btnCadastrarMedico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarMedico.IsBackStageButton = false;
            this.btnCadastrarMedico.Location = new System.Drawing.Point(12, 222);
            this.btnCadastrarMedico.Name = "btnCadastrarMedico";
            this.btnCadastrarMedico.Size = new System.Drawing.Size(166, 155);
            this.btnCadastrarMedico.TabIndex = 3;
            this.btnCadastrarMedico.Text = "Cadastrar Médico";
            this.btnCadastrarMedico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarMedico.Click += new System.EventHandler(this.btnCadastrarMedico_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(166, 155);
            this.buttonAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.Image = global::APRESENTACAO.Properties.Resources.relatorio166x120;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(12, 43);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(166, 155);
            this.buttonAdv1.TabIndex = 4;
            this.buttonAdv1.Text = "Relatórios";
            this.buttonAdv1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraçãoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sobreToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.administraçãoToolStripMenuItem.Text = "&Administração";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pontosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.médicosToolStripMenuItem.Text = "&Médicos";
            this.médicosToolStripMenuItem.Click += new System.EventHandler(this.médicosToolStripMenuItem_Click);
            // 
            // pontosToolStripMenuItem
            // 
            this.pontosToolStripMenuItem.Name = "pontosToolStripMenuItem";
            this.pontosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pontosToolStripMenuItem.Text = "&Pontos";
            this.pontosToolStripMenuItem.Click += new System.EventHandler(this.pontosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "S&air";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusBarAdvPanel1
            // 
            this.statusBarAdvPanel1.BeforeTouchSize = new System.Drawing.Size(68, 25);
            this.statusBarAdvPanel1.Location = new System.Drawing.Point(0, 575);
            this.statusBarAdvPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarAdvPanel1.Name = "statusBarAdvPanel1";
            this.statusBarAdvPanel1.Size = new System.Drawing.Size(68, 25);
            this.statusBarAdvPanel1.TabIndex = 6;
            this.statusBarAdvPanel1.Text = "Versão 1.1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.statusBarAdvPanel1);
            this.Controls.Add(this.clock1);
            this.Controls.Add(this.btnCadastrarMedico);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Acesso - Gerencial";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.btnOnOff)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.Clock clock1;
        private Syncfusion.Windows.Forms.Tools.ToggleButton btnOnOff;
        private Syncfusion.Windows.Forms.ButtonAdv btnCadastrarMedico;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pontosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel1;
    }
}