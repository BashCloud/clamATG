using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ClamWinApp
{
    public partial class ATGmain : Form
    {
        public static Color mainBG = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
        public ATGmain()
        {
            InitializeComponent();
            this.BackColor = mainBG;
        }
        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public void MoveWindow(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }
        Color hoverColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        List<UserControl> listViews = new List<UserControl>();
        List<Button> listButtons = new List<Button>();
        String[] listTitle = new String[] 
            {"Dashboard","Scan","Firewall",
             "Cleaner","Setings","About",
             "Report","Help","Update"};
        public void MakeActive(int index)
        {
            int i;
            for (i = 0; i < listButtons.Count; i++)
            {
                if (i == index)
                {
                    listViews[i].Visible = true;
                    listButtons[i].BackColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
                    mainTitle.Text = listTitle[i];
                }

                else
                {
                    listViews[i].Visible = false;
                    listButtons[i].BackColor = Color.Transparent;
                }
                    
            }
        }
        private void clamATG_Load(object sender, EventArgs e)
        {
            listViews.Add(dashboard1);
            listViews.Add(atGscan1);
            listViews.Add(atGfirewall1);
            listViews.Add(atGcleaner1);
            listViews.Add(atGsettings1);
            listViews.Add(atGabout1);
            listViews.Add(atGreport1);
            listViews.Add(atGhelp1);
            listViews.Add(atGupdate1);

            listButtons.Add(button2);
            listButtons.Add(button1);
            listButtons.Add(button3);
            listButtons.Add(button4);
            listButtons.Add(button5);
            listButtons.Add(button6);
            listButtons.Add(button10);
            listButtons.Add(button11);
            listButtons.Add(button9);
            MakeActive(0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MakeActive(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeActive(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MakeActive(2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MakeActive(3);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MakeActive(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MakeActive(5);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MakeActive(6);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MakeActive(7);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            MakeActive(8);
        }
    }
}
