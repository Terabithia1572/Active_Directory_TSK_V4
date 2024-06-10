
namespace Active_Directory_TSK_V1
{
    partial class frm_Register2
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chbx_sifreyiGoster = new MetroFramework.Controls.MetroCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_kayitOl = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel3.Location = new System.Drawing.Point(248, 411);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Giriş Yap";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // chbx_sifreyiGoster
            // 
            this.chbx_sifreyiGoster.AutoSize = true;
            this.chbx_sifreyiGoster.Location = new System.Drawing.Point(27, 415);
            this.chbx_sifreyiGoster.Name = "chbx_sifreyiGoster";
            this.chbx_sifreyiGoster.Size = new System.Drawing.Size(92, 15);
            this.chbx_sifreyiGoster.TabIndex = 19;
            this.chbx_sifreyiGoster.Text = "Şifreyi Göster";
            this.chbx_sifreyiGoster.UseSelectable = true;
            this.chbx_sifreyiGoster.CheckedChanged += new System.EventHandler(this.chbx_sifreyiGoster_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Active_Directory_TSK_V1.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(102, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_kayitOl
            // 
            this.btn_kayitOl.ActiveControl = null;
            this.btn_kayitOl.Location = new System.Drawing.Point(27, 458);
            this.btn_kayitOl.Name = "btn_kayitOl";
            this.btn_kayitOl.Size = new System.Drawing.Size(280, 53);
            this.btn_kayitOl.TabIndex = 21;
            this.btn_kayitOl.Text = "Kayıt Ol";
            this.btn_kayitOl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_kayitOl.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_kayitOl.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_kayitOl.UseSelectable = true;
            this.btn_kayitOl.Click += new System.EventHandler(this.btn_kayitOl_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 301);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Şifre:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 236);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Kullanıcı Adı:";
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
            this.txtPassword.Location = new System.Drawing.Point(27, 323);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(280, 26);
            this.txtPassword.TabIndex = 18;
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
            this.txtUsername.Location = new System.Drawing.Point(27, 258);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(280, 26);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 360);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Şifre:";
            // 
            // txtPassword1
            // 
            // 
            // 
            // 
            this.txtPassword1.CustomButton.Image = null;
            this.txtPassword1.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.txtPassword1.CustomButton.Name = "";
            this.txtPassword1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword1.CustomButton.TabIndex = 1;
            this.txtPassword1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword1.CustomButton.UseSelectable = true;
            this.txtPassword1.CustomButton.Visible = false;
            this.txtPassword1.DisplayIcon = true;
            this.txtPassword1.Icon = global::Active_Directory_TSK_V1.Properties.Resources._lock;
            this.txtPassword1.Lines = new string[0];
            this.txtPassword1.Location = new System.Drawing.Point(27, 382);
            this.txtPassword1.MaxLength = 32767;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '\0';
            this.txtPassword1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword1.SelectedText = "";
            this.txtPassword1.SelectionLength = 0;
            this.txtPassword1.SelectionStart = 0;
            this.txtPassword1.ShortcutsEnabled = true;
            this.txtPassword1.Size = new System.Drawing.Size(280, 26);
            this.txtPassword1.TabIndex = 25;
            this.txtPassword1.UseSelectable = true;
            this.txtPassword1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frm_Register2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 555);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.chbx_sifreyiGoster);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_kayitOl);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "frm_Register2";
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.frm_Register2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox chbx_sifreyiGoster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btn_kayitOl;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPassword1;
    }
}