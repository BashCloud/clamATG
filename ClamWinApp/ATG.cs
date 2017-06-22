using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClamWinApp
{
    public partial class ATG : Form
    {
        List<Panel> listPanel = new List<Panel>();
        public ATG()
        {
            InitializeComponent();
        }

        private void ATG_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel6);
            listPanel.Add(panel7);
            listPanel.Add(panel8);
            listPanel.Add(panel9);
            listPanel[5].BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            listPanel[2].BringToFront();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            listPanel[3].BringToFront();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            listPanel[4].BringToFront();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            listPanel[5].BringToFront();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            ClamWinSettingsForm settingBox = new ClamWinSettingsForm();
            settingBox.TopLevel = false;
            settingBox.Show();
            //settingBox.MdiParent = this.;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
