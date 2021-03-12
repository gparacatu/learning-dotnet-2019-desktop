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

namespace APRESENTACAO
{
    public partial class FrmSplash : Syncfusion.Windows.Forms.MetroForm
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void iniciarTimer()
        {
            // Set the interval for the timer.
            timerSplash.Interval = 200;
            // Connect the Tick event of the timer to its event handler.
            timerSplash.Tick += new EventHandler(IncreaseProgressBar);
            // Start the timer.
            timerSplash.Start();
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            // Increment the value of the ProgressBar a value of one each time.
            pgbSplash.Increment();
            // Display the textual value of the ProgressBar in the StatusBar control's first panel.
            //statusBarPanel1.Text = progressBar1.Value.ToString() + "% Completed";
            // Determine if we have completed by comparing the value of the Value property to the Maximum value.
            if (pgbSplash.Value == pgbSplash.Maximum)
            {   // Stop the timer.
                timerSplash.Stop();
                this.Visible = false;
                ControleFormulario.abreFrmLogon();

            }
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            iniciarTimer();
        }
    }
}
