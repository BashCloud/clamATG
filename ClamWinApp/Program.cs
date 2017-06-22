using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace ClamWinApp
{
    #region Program class
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( string [] args)
        {
            bool Created;
            Mutex mutex = new Mutex(false, "ClamWinStartupMutex", out Created);
            
            if (!Created)
            {
                // ClamWin instance already exist, let pop it up
                IntPtr Handle = Win32API.FindWindow("WindowsForms10.Window.8.app.0.378734a", "ClamWin Free Antivirus");

                if (0 != (int)Handle)
                {
                    Win32API.SetWindowPos(Handle,
                                          Win32API.HWND_TOP,
                                          0,
                                          0,
                                          0,
                                          0,
                                          Win32API.SWP_NOSIZE |
                                          Win32API.SWP_NOMOVE |
                                          Win32API.SWP_SHOWWINDOW
                                         );
                    Win32API.SetForegroundWindow(Handle);

                    OnArguments(args, Handle);

                    mutex.Close();
                    return;
                }
            }

            Application.EnableVisualStyles();            
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ClamWinMainForm(args));
            Application.Run(new ATGmain());

            /*try
            {
                Application.Run(new ClamWinMainForm(args));
            }
            catch (SystemException exc)
            { 
                MessageBox.Show( "Exception occured!\r\nWith message - \"" + exc.Message + "\"\r\n Source - \"" + exc.Source + "\"",
                                 "ClamWin",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }*/
            
            mutex.Close();
        }
        /// <summary>
        /// Check arguments and send corresponding mesages to existing instance of ClamWin
        /// </summary>
        /// <param name="args"></param>
        public static void OnArguments(string[] args, IntPtr Handle)
        {
            foreach (string arg in args)
            {
                if (arg == ClamWinScheduleData.UpdateArg)
                {
                    Win32API.PostMessage(Handle, ClamWinMainForm.UM_SCHEDULED_UPDATE, 0, 0);
                }
                else if (arg == ClamWinScheduleData.ScanArg)
                {
                    Win32API.PostMessage(Handle, ClamWinMainForm.UM_SCHEDULED_SCAN, 0, 0);
                }
                else if (arg == ClamWinScheduleData.ScanCriticalArg)
                {
                    Win32API.PostMessage(Handle, ClamWinMainForm.UM_SCHEDULED_SCAN_CRITICAL, 0, 0);
                }
                else if (arg == ClamWinScheduleData.ScanMyPCArg)
                {
                    Win32API.PostMessage(Handle, ClamWinMainForm.UM_SCHEDULED_SCAN_MY_PC, 0, 0);
                }            
            }        
        }
    }
    #endregion
}