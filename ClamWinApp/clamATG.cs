﻿using System;
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
    public partial class clamATG : Form
    {
        public clamATG()
        {
            InitializeComponent();
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {

        }

        List<UserControl> listViews = new List<UserControl>();
        List<Button> listButtons = new List<Button>();
        public void MakeActive(int index)
        {
            int i;
            for (i = 0; i < listButtons.Count; i++)
            {
                if (i == index)
                {
                    listViews[i].Visible = true;
                    listButtons[i].BackColor = Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
                }

                else
                {
                    //listViews[i].Visible = false;
                    listButtons[i].BackColor = Color.Transparent;
                }
                    
            }
        }
        private void clamATG_Load(object sender, EventArgs e)
        {
            listViews.Add(dashboard1);
            listViews.Add(atGscan1);
            listButtons.Add(button2);
            listButtons.Add(button1);
            listButtons.Add(button3);
            listButtons.Add(button4);
            listButtons.Add(button5);
            listButtons.Add(button6);
            listButtons.Add(button10);
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
            Process.Start("C:/FWBuilder51/fwbuilder.exe");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Program Files (x86)/BleachBit/bleachbit.exe");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ClamWinSettingsForm formSettings = new ClamWinSettingsForm();
            formSettings.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] arg = { };
            ClamWinMainForm old = new ClamWinMainForm(arg);
            old.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
