
namespace Active_Directory_TSK_V1
{
    partial class frm_Login2
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
            this.chbx_windowsIleBaslama = new MetroFramework.Controls.MetroCheckBox();
            this.chbx_sifreyiGoster = new MetroFramework.Controls.MetroCheckBox();
            this.btn_girisYap = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chbx_windowsIleBaslama
            // 
            this.chbx_windowsIleBaslama.AutoSize = true;
            this.chbx_windowsIleBaslama.Location = new System.Drawing.Point(229, 29);
            this.chbx_windowsIleBaslama.Name = "chbx_windowsIleBaslama";
            this.chbx_windowsIleBaslama.Size = new System.Drawing.Size(132, 15);
            this.chbx_windowsIleBaslama.TabIndex = 13;
            this.chbx_windowsIleBaslama.Text = "Windows ile başlasın";
            this.chbx_windowsIleBaslama.UseSelectable = true;
            this.chbx_windowsIleBaslama.CheckedChanged += new System.EventHandler(this.chbx_windowsIleBaslama_CheckedChanged);
            // 
            // chbx_sifreyiGoster
            // 
            this.chbx_sifreyiGoster.AutoSize = true;
            this.chbx_sifreyiGoster.Location = new System.Drawing.Point(42, 346);
            this.chbx_sifreyiGoster.Name = "chbx_sifreyiGoster";
            this.chbx_sifreyiGoster.Size = new System.Drawing.Size(92, 15);
            this.chbx_sifreyiGoster.TabIndex = 10;
            this.chbx_sifreyiGoster.Text = "Şifreyi Göster";
            this.chbx_sifreyiGoster.UseSelectable = true;
            this.chbx_sifreyiGoster.CheckedChanged += new System.EventHandler(this.chbx_sifreyiGoster_CheckedChanged);
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.ActiveControl = null;
            this.btn_girisYap.Location = new System.Drawing.Point(42, 383);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(280, 53);
            this.btn_girisYap.TabIndex = 12;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_girisYap.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_girisYap.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_girisYap.UseSelectable = true;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 286);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Şifre:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 224);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Kullanıcı Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Active_Directory_TSK_V1.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(117, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = global::Active_Directory_TSK_V1.Properties.Resources._lock;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(42, 311);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(280, 26);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.Icon = global::Active_Directory_TSK_V1.Properties.Resources.man_user01;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(42, 246);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(280, 26);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel3.Location = new System.Drawing.Point(225, 342);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Hesap Oluştur";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // frm_Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 488);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.chbx_windowsIleBaslama);
            this.Controls.Add(this.chbx_sifreyiGoster);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "frm_Login2";
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.frm_Login2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chbx_windowsIleBaslama;
        private MetroFramework.Controls.MetroCheckBox chbx_sifreyiGoster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btn_girisYap;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}