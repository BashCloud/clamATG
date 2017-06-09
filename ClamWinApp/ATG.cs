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
        int index;
        public ATG()
        {
            InitializeComponent();
        }

        private void ATG_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();
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
    }
}
