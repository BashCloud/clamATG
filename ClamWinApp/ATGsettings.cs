﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ClamWinApp
{
    public partial class ATGsettings : UserControl
    {
        public ATGsettings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ClamWinSettingsForm formSettings = new ClamWinSettingsForm();
            formSettings.Show();
        }
    }
}
