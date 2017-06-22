using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace ClamWinApp
{
    public partial class ATGcleaner : UserControl
    {
        public ATGcleaner()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Program Files (x86)/BleachBit/bleachbit.exe");
        }
    }
}
