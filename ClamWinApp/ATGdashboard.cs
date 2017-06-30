using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ClamWinApp
{
    public partial class ATGdashboard : UserControl
    {
        public ATGdashboard()
        {
            InitializeComponent();
            // Scanner initialization            
            /*if (!ClamWinScanner.Open(this.Handle))
            {
                System.Windows.Forms.MessageBox.Show("Unable to open main scanner service.",
                                                     "Asystguard",
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Error);
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //to be deleted.
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //To be deleted.
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //to be deleted.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // to be deleted
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // to be deleted
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // to be deleted
        }
    }
}
