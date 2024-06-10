
namespace Active_Directory_TSK_V1
{
    partial class frm_KullaniciYetki
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
            this.textBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.buttonSubmit = new MetroFramework.Controls.MetroTile();
            this.labelResult = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBoxFolderName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxDrives = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxLDAPPaths = new MetroFramework.Controls.MetroComboBox();
            this.textBoxDomain = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            // 
            // 
            // 
            this.textBoxUsername.CustomButton.Image = null;
            this.textBoxUsername.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.textBoxUsername.CustomButton.Name = "";
            this.textBoxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxUsername.CustomButton.TabIndex = 1;
            this.textBoxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxUsername.CustomButton.UseSelectable = true;
            this.textBoxUsername.CustomButton.Visible = false;
            this.textBoxUsername.Lines = new string[0];
            this.textBoxUsername.Location = new System.Drawing.Point(195, 242);
            this.textBoxUsername.MaxLength = 32767;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.SelectionLength = 0;
            this.textBoxUsername.SelectionStart = 0;
            this.textBoxUsername.ShortcutsEnabled = true;
            this.textBoxUsername.Size = new System.Drawing.Size(226, 23);
            this.textBoxUsername.TabIndex = 68;
            this.textBoxUsername.UseSelectable = true;
            this.textBoxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 242);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 19);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = "Kullanıcı Logon Name:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.ActiveControl = null;
            this.buttonSubmit.Location = new System.Drawing.Point(195, 279);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(50, 50);
            this.buttonSubmit.TabIndex = 70;
            this.buttonSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSubmit.TileImage = global::Active_Directory_TSK_V1.Properties.Resources.plus__1_;
            this.buttonSubmit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSubmit.UseSelectable = true;
            this.buttonSubmit.UseTileImage = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(195, 60);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(227, 38);
            this.labelResult.TabIndex = 71;
            this.labelResult.Text = "Kullanıcı Yoksa Lütfen Kullanıcı Ekleyin.\r\n";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(147, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 72;
            this.metroLabel3.Text = "NOT:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(188, 332);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(62, 19);
            this.metroLabel12.TabIndex = 73;
            this.metroLabel12.Text = "Yetki Ver:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 213);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 69;
            this.metroLabel2.Text = "Klasör Adı Giriniz:";
            // 
            // textBoxFolderName
            // 
            // 
            // 
            // 
            this.textBoxFolderName.CustomButton.Image = null;
            this.textBoxFolderName.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.textBoxFolderName.CustomButton.Name = "";
            this.textBoxFolderName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxFolderName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxFolderName.CustomButton.TabIndex = 1;
            this.textBoxFolderName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxFolderName.CustomButton.UseSelectable = true;
            this.textBoxFolderName.CustomButton.Visible = false;
            this.textBoxFolderName.Lines = new string[0];
            this.textBoxFolderName.Location = new System.Drawing.Point(195, 213);
            this.textBoxFolderName.MaxLength = 32767;
            this.textBoxFolderName.Name = "textBoxFolderName";
            this.textBoxFolderName.PasswordChar = '\0';
            this.textBoxFolderName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxFolderName.SelectedText = "";
            this.textBoxFolderName.SelectionLength = 0;
            this.textBoxFolderName.SelectionStart = 0;
            this.textBoxFolderName.ShortcutsEnabled = true;
            this.textBoxFolderName.Size = new System.Drawing.Size(226, 23);
            this.textBoxFolderName.TabIndex = 68;
            this.textBoxFolderName.UseSelectable = true;
            this.textBoxFolderName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxFolderName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(50, 147);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 69;
            this.metroLabel4.Text = "Disk Seçin:";
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.ItemHeight = 23;
            this.comboBoxDrives.Location = new System.Drawing.Point(195, 147);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(227, 29);
            this.comboBoxDrives.TabIndex = 74;
            this.comboBoxDrives.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(50, 112);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 69;
            this.metroLabel5.Text = "Domain Seçin:";
            // 
            // comboBoxLDAPPaths
            // 
            this.comboBoxLDAPPaths.FormattingEnabled = true;
            this.comboBoxLDAPPaths.ItemHeight = 23;
            this.comboBoxLDAPPaths.Location = new System.Drawing.Point(195, 112);
            this.comboBoxLDAPPaths.Name = "comboBoxLDAPPaths";
            this.comboBoxLDAPPaths.Size = new System.Drawing.Size(227, 29);
            this.comboBoxLDAPPaths.TabIndex = 74;
            this.comboBoxLDAPPaths.UseSelectable = true;
            // 
            // textBoxDomain
            // 
            // 
            // 
            // 
            this.textBoxDomain.CustomButton.Image = null;
            this.textBoxDomain.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.textBoxDomain.CustomButton.Name = "";
            this.textBoxDomain.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxDomain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxDomain.CustomButton.TabIndex = 1;
            this.textBoxDomain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxDomain.CustomButton.UseSelectable = true;
            this.textBoxDomain.CustomButton.Visible = false;
            this.textBoxDomain.Lines = new string[0];
            this.textBoxDomain.Location = new System.Drawing.Point(195, 184);
            this.textBoxDomain.MaxLength = 32767;
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.PasswordChar = '\0';
            this.textBoxDomain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDomain.SelectedText = "";
            this.textBoxDomain.SelectionLength = 0;
            this.textBoxDomain.SelectionStart = 0;
            this.textBoxDomain.ShortcutsEnabled = true;
            this.textBoxDomain.Size = new System.Drawing.Size(226, 23);
            this.textBoxDomain.TabIndex = 75;
            this.textBoxDomain.UseSelectable = true;
            this.textBoxDomain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxDomain.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(50, 184);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 19);
            this.metroLabel6.TabIndex = 76;
            this.metroLabel6.Text = "Domain Giriniz";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(427, 184);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 38);
            this.metroLabel7.TabIndex = 76;
            this.metroLabel7.Text = "kkk.tsk,\r\ntest.local";
            // 
            // frm_KullaniciYetki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 398);
            this.Controls.Add(this.textBoxDomain);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.comboBoxLDAPPaths);
            this.Controls.Add(this.comboBoxDrives);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.textBoxFolderName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frm_KullaniciYetki";
            this.Text = "Kullanıcı Yetkileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile buttonSubmit;
        private MetroFramework.Controls.MetroTextBox textBoxUsername;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel labelResult;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBoxFolderName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox comboBoxDrives;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox comboBoxLDAPPaths;
        private MetroFramework.Controls.MetroTextBox textBoxDomain;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}