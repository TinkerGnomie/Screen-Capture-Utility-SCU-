using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Capture_Utility
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        public void SettingsWindow_Load(object sender, EventArgs e)
        {
            string imgurName = Properties.Settings.Default.imgurUsernameSetting.ToString();
            string saveLocation = Properties.Settings.Default.saveLocationSetting.ToString();

            imgurusernameTextbox.Text = imgurName;
            savelocationTextBox.Text = saveLocation;
        }

        private void BrowseLocation(object sender, EventArgs e)
        {
            FolderBrowserDialog BL = new FolderBrowserDialog();
            BL.ShowNewFolderButton = true;
            BL.ShowDialog();
            if(BL.ShowDialog() == DialogResult.OK)
            {
                savelocationTextBox.Text = BL.SelectedPath;
            }
        }

        private void Set_Default_Location(object sender, EventArgs e)
        {
            savelocationTextBox.Text = "C:\\ScreenShots\\";
        }

        public void ImgurUsernameSetting(object sender, EventArgs e)
        {

        }

        public void SaveLocation(object sender, EventArgs e)
        {

        }

        private void SaveSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.imgurUsernameSetting = imgurusernameTextbox.Text;
            Properties.Settings.Default.saveLocationSetting = savelocationTextBox.Text;

            Properties.Settings.Default.Save();
        }
    }
}
