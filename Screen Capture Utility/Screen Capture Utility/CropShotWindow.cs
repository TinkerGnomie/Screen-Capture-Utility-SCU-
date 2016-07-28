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

namespace Screen_Capture_Utility
{
    public partial class CropShotWindow : Form
    {
        public CropShotWindow()
        {
            InitializeComponent();
        }

        private void CropShot(object sender, KeyEventArgs e)
        {
            string imgurUsernameValue = Properties.Settings.Default.imgurUsernameSetting.ToString();
            string saveLocationValue = Properties.Settings.Default.saveLocationSetting.ToString();

            if (e.KeyCode == Keys.Enter)
            {
                Rectangle bounds = this.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        String filename = "ScreenCapture-" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".png";
                        this.FormBorderStyle = FormBorderStyle.None;
                        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                        bitmap.Save(saveLocationValue + filename);
                        this.FormBorderStyle = FormBorderStyle.Sizable;
                    }
                }
                Process.Start("explorer.exe", saveLocationValue);
                Process.Start("https://" + imgurUsernameValue + ".imgur.com/all");
            }

            if (e.KeyCode == Keys.Q)
            {
                Rectangle bounds = this.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        String filename = "ScreenCapture-" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".png";
                        this.FormBorderStyle = FormBorderStyle.None;
                        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                        bitmap.Save(saveLocationValue + filename);
                        this.FormBorderStyle = FormBorderStyle.Sizable;
                    }
                }
                //Process.Start("explorer.exe", "C:\\ScreenShots\\");
                //Process.Start("https://amaurea.imgur.com/all");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Opacity = .5;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CropShotWindow));
            this.SuspendLayout();
            // 
            // CropShotWindow
            // 
            this.ClientSize = new System.Drawing.Size(382, 306);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CropShotWindow";
            this.Text = "Press Enter to Capture or Q for QuickShot";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CropShot);
            this.ResumeLayout(false);

        }
    }
}
