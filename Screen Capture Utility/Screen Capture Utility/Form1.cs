using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Screen_Capture_Utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class stirngs
        {
            public static string username = Environment.UserName;
            public static string myPictures = "C:\\Users\\" + username + "\\Pictures\\";
        }

        public class WindowsHandling
        {
            [DllImport("user32.dll")]
            private static extern IntPtr GetForegroundWindow();

            [DllImport("user32.dll")]
            private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

            [StructLayout(LayoutKind.Sequential)]
            private struct Rect
            {
                public int Left;
                public int Top;
                public int Right;
                public int Bottom;
            }

            [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
            public static extern IntPtr GetDesktopWindow();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;

            if (Directory.Exists("C:\\ScreenShots\\"))
            {

            }
            else
            {
                Directory.CreateDirectory("C:\\ScreenShots\\");
            }
        }

        private void ScreenShot(object sender, EventArgs e)
        {
            string imgurUsernameValue = Properties.Settings.Default.imgurUsernameSetting.ToString();
            string saveLocationValue = Properties.Settings.Default.saveLocationSetting.ToString();

            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            using (Bitmap bmp = new Bitmap(screenWidth, screenHeight))
            {
                using(Graphics g = Graphics.FromImage(bmp))
                {
                    String filename = "ScreenCapture-" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".jpg";
                    g.CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);
                    bmp.Save(saveLocationValue + filename);
                    this.Hide();
                }
            }

            Process.Start("explorer.exe", saveLocationValue);
            Process.Start("https://" + imgurUsernameValue + ".imgur.com/all");
        }

        private void ScreenShotOnly(object sender, EventArgs e)
        {
            string imgurUsernameValue = Properties.Settings.Default.imgurUsernameSetting.ToString();
            string saveLocationValue = Properties.Settings.Default.saveLocationSetting.ToString();

            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            using (Bitmap bmp = new Bitmap(screenWidth, screenHeight))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    String filename = "ScreenCapture-" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".jpg";
                    g.CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);
                    bmp.Save(saveLocationValue + filename);
                    this.Hide();
                }

            }
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            Form openSettings = new SettingsWindow();
            openSettings.Show();
        }

        private void openCropShot(object sender, EventArgs e)
        {
            Form cropshot = new CropShotWindow();
            cropshot.Show();
        }

        private void Exit(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }
    }
}
