
namespace Active_Directory_TSK_V1
{
    partial class frm_OrganizationUnityCreate
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
            this.ouNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.createOUButton = new MetroFramework.Controls.MetroTile();
            this.comboBoxLDAPPaths = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ouNameTextBox
            // 
            // 
            // 
            // 
            this.ouNameTextBox.CustomButton.Image = null;
            this.ouNameTextBox.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.ouNameTextBox.CustomButton.Name = "";
            this.ouNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ouNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ouNameTextBox.CustomButton.TabIndex = 1;
            this.ouNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ouNameTextBox.CustomButton.UseSelectable = true;
            this.ouNameTextBox.CustomButton.Visible = false;
            this.ouNameTextBox.Lines = new string[0];
            this.ouNameTextBox.Location = new System.Drawing.Point(208, 109);
            this.ouNameTextBox.MaxLength = 32767;
            this.ouNameTextBox.Name = "ouNameTextBox";
            this.ouNameTextBox.PasswordChar = '\0';
            this.ouNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ouNameTextBox.SelectedText = "";
            this.ouNameTextBox.SelectionLength = 0;
            this.ouNameTextBox.SelectionStart = 0;
            this.ouNameTextBox.ShortcutsEnabled = true;
            this.ouNameTextBox.Size = new System.Drawing.Size(226, 23);
            this.ouNameTextBox.TabIndex = 71;
            this.ouNameTextBox.UseSelectable = true;
            this.ouNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ouNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(57, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 72;
            this.metroLabel1.Text = "Organization Unity Adı:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(263, 257);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(51, 19);
            this.metroLabel12.TabIndex = 75;
            this.metroLabel12.Text = "Oluştur";
            // 
            // createOUButton
            // 
            this.createOUButton.ActiveControl = null;
            this.createOUButton.Location = new System.Drawing.Point(263, 204);
            this.createOUButton.Name = "createOUButton";
            this.createOUButton.Size = new System.Drawing.Size(50, 50);
            this.createOUButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.createOUButton.TabIndex = 74;
            this.createOUButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.createOUButton.TileImage = global::Active_Directory_TSK_V1.Properties.Resources.dry_clean__1_;
            this.createOUButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createOUButton.UseSelectable = true;
            this.createOUButton.UseTileImage = true;
            this.createOUButton.Click += new System.EventHandler(this.createOUButton_Click);
            // 
            // comboBoxLDAPPaths
            // 
            this.comboBoxLDAPPaths.FormattingEnabled = true;
            this.comboBoxLDAPPaths.ItemHeight = 23;
            this.comboBoxLDAPPaths.Location = new System.Drawing.Point(208, 138);
            this.comboBoxLDAPPaths.Name = "comboBoxLDAPPaths";
            this.comboBoxLDAPPaths.Size = new System.Drawing.Size(226, 29);
            this.comboBoxLDAPPaths.TabIndex = 76;
            this.comboBoxLDAPPaths.UseSelectable = true;
           // this.comboBoxLDAPPaths.SelectedIndexChanged += new System.EventHandler(this.comboBoxLDAPPaths_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(57, 138);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 77;
            this.metroLabel2.Text = "Domain Seç:";
            // 
            // frm_OrganizationUnityCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 343);
            this.Controls.Add(this.comboBoxLDAPPaths);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.createOUButton);
            this.Controls.Add(this.ouNameTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frm_OrganizationUnityCreate";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Organization Unity Oluşturma Sayfası";
          //  this.Load += new System.EventHandler(this.frm_OrganizationUnityCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox ouNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTile createOUButton;
        private MetroFramework.Controls.MetroComboBox comboBoxLDAPPaths;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}