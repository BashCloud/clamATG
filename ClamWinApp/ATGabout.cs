using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ClamWinApp
{
    public partial class ATGabout : UserControl
    {
        public ATGabout()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string[] arg = { };
            ClamWinMainForm old = new ClamWinMainForm(arg);
            old.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //to be deleted.
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //to be deleted.
        }
    }
}
