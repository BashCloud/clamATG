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
    }
}
