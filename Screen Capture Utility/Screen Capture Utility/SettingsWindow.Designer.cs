namespace Screen_Capture_Utility
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imgurusernameTextbox = new System.Windows.Forms.TextBox();
            this.savelocationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.defaultLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveSettings);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imgur Username";
            // 
            // imgurusernameTextbox
            // 
            this.imgurusernameTextbox.Location = new System.Drawing.Point(103, 13);
            this.imgurusernameTextbox.Name = "imgurusernameTextbox";
            this.imgurusernameTextbox.Size = new System.Drawing.Size(169, 20);
            this.imgurusernameTextbox.TabIndex = 2;
            // 
            // savelocationTextBox
            // 
            this.savelocationTextBox.Location = new System.Drawing.Point(103, 40);
            this.savelocationTextBox.Name = "savelocationTextBox";
            this.savelocationTextBox.Size = new System.Drawing.Size(169, 20);
            this.savelocationTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save location";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(246, 67);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(26, 23);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseLocation);
            // 
            // defaultLocation
            // 
            this.defaultLocation.Location = new System.Drawing.Point(103, 67);
            this.defaultLocation.Name = "defaultLocation";
            this.defaultLocation.Size = new System.Drawing.Size(137, 23);
            this.defaultLocation.TabIndex = 6;
            this.defaultLocation.Text = "Default location";
            this.defaultLocation.UseVisualStyleBackColor = true;
            this.defaultLocation.Click += new System.EventHandler(this.Set_Default_Location);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.defaultLocation);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.savelocationTextBox);
            this.Controls.Add(this.imgurusernameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imgurusernameTextbox;
        private System.Windows.Forms.TextBox savelocationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button defaultLocation;
    }
}