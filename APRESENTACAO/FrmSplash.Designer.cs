#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace APRESENTACAO
{
    partial class FrmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.pgbSplash = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pgbSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbSplash
            // 
            this.pgbSplash.BackColor = System.Drawing.Color.Gray;
            this.pgbSplash.BackGradientEndColor = System.Drawing.Color.Gray;
            this.pgbSplash.BackGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.pgbSplash.BackgroundFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient;
            this.pgbSplash.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube;
            this.pgbSplash.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.pgbSplash.BackSegments = false;
            this.pgbSplash.BackTubeEndColor = System.Drawing.Color.White;
            this.pgbSplash.BackTubeStartColor = System.Drawing.Color.Black;
            this.pgbSplash.CustomText = null;
            this.pgbSplash.CustomWaitingRender = false;
            this.pgbSplash.Dock = System.Windows.Forms.DockStyle.Top;
            this.pgbSplash.FontColor = System.Drawing.Color.White;
            this.pgbSplash.ForeColor = System.Drawing.Color.White;
            this.pgbSplash.ForegroundImage = null;
            this.pgbSplash.ForeSegments = false;
            this.pgbSplash.GradientEndColor = System.Drawing.Color.Black;
            this.pgbSplash.GradientStartColor = System.Drawing.Color.Red;
            this.pgbSplash.Location = new System.Drawing.Point(0, 0);
            this.pgbSplash.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.ProgressFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient;
            this.pgbSplash.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient;
            this.pgbSplash.SegmentWidth = 12;
            this.pgbSplash.Size = new System.Drawing.Size(550, 16);
            this.pgbSplash.Step = 13;
            this.pgbSplash.TabIndex = 1;
            this.pgbSplash.Text = "progressBarAdv1";
            this.pgbSplash.ThemesEnabled = true;
            this.pgbSplash.TubeEndColor = System.Drawing.Color.White;
            this.pgbSplash.TubeStartColor = System.Drawing.Color.White;
            this.pgbSplash.UseWaitCursor = true;
            this.pgbSplash.Value = 0;
            this.pgbSplash.WaitingGradientWidth = 400;
            // 
            // timerSplash
            // 
            this.timerSplash.Interval = 10;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APRESENTACAO.Properties.Resources.PRIMETECHLOGO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.Controls.Add(this.pgbSplash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ponto";
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pgbSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv pgbSplash;
        private System.Windows.Forms.Timer timerSplash;
    }
}