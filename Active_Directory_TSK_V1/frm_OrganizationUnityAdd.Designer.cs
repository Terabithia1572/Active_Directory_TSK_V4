
namespace Active_Directory_TSK_V1
{
    partial class frm_OrganizationUnityAdd
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
            this.ouComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.newOuNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.createOuButton = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbxDCPath = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ouComboBox
            // 
            this.ouComboBox.FormattingEnabled = true;
            this.ouComboBox.ItemHeight = 23;
            this.ouComboBox.Location = new System.Drawing.Point(204, 151);
            this.ouComboBox.Name = "ouComboBox";
            this.ouComboBox.Size = new System.Drawing.Size(339, 29);
            this.ouComboBox.TabIndex = 1;
            this.ouComboBox.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(53, 151);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(145, 19);
            this.metroLabel7.TabIndex = 54;
            this.metroLabel7.Text = "Organization Unity Seç:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 195);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 55;
            this.metroLabel1.Text = "Organization Unity Adı:";
            // 
            // newOuNameTextBox
            // 
            // 
            // 
            // 
            this.newOuNameTextBox.CustomButton.Image = null;
            this.newOuNameTextBox.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.newOuNameTextBox.CustomButton.Name = "";
            this.newOuNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.newOuNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newOuNameTextBox.CustomButton.TabIndex = 1;
            this.newOuNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newOuNameTextBox.CustomButton.UseSelectable = true;
            this.newOuNameTextBox.CustomButton.Visible = false;
            this.newOuNameTextBox.Lines = new string[0];
            this.newOuNameTextBox.Location = new System.Drawing.Point(204, 195);
            this.newOuNameTextBox.MaxLength = 32767;
            this.newOuNameTextBox.Name = "newOuNameTextBox";
            this.newOuNameTextBox.PasswordChar = '\0';
            this.newOuNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newOuNameTextBox.SelectedText = "";
            this.newOuNameTextBox.SelectionLength = 0;
            this.newOuNameTextBox.SelectionStart = 0;
            this.newOuNameTextBox.ShortcutsEnabled = true;
            this.newOuNameTextBox.Size = new System.Drawing.Size(339, 23);
            this.newOuNameTextBox.TabIndex = 2;
            this.newOuNameTextBox.UseSelectable = true;
            this.newOuNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newOuNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createOuButton
            // 
            this.createOuButton.ActiveControl = null;
            this.createOuButton.Location = new System.Drawing.Point(332, 259);
            this.createOuButton.Name = "createOuButton";
            this.createOuButton.Size = new System.Drawing.Size(50, 50);
            this.createOuButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.createOuButton.TabIndex = 3;
            this.createOuButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.createOuButton.TileImage = global::Active_Directory_TSK_V1.Properties.Resources.dry_clean__1_;
            this.createOuButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createOuButton.UseSelectable = true;
            this.createOuButton.UseTileImage = true;
            this.createOuButton.Click += new System.EventHandler(this.createOuButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(53, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 54;
            this.metroLabel2.Text = "Domain Seç:";
            // 
            // cbxDCPath
            // 
            this.cbxDCPath.FormattingEnabled = true;
            this.cbxDCPath.ItemHeight = 23;
            this.cbxDCPath.Location = new System.Drawing.Point(204, 116);
            this.cbxDCPath.Name = "cbxDCPath";
            this.cbxDCPath.Size = new System.Drawing.Size(339, 29);
            this.cbxDCPath.TabIndex = 1;
            this.cbxDCPath.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(332, 312);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(51, 19);
            this.metroLabel12.TabIndex = 56;
            this.metroLabel12.Text = "Oluştur";
            this.metroLabel12.Click += new System.EventHandler(this.metroLabel12_Click);
            // 
            // frm_OrganizationUnityAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.newOuNameTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.createOuButton);
            this.Controls.Add(this.cbxDCPath);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ouComboBox);
            this.Controls.Add(this.metroLabel7);
            this.Name = "frm_OrganizationUnityAdd";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "İç İçe Organization Unity Oluşturma";
            this.Load += new System.EventHandler(this.frm_OrganizationUnityAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile createOuButton;
        private MetroFramework.Controls.MetroComboBox ouComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox newOuNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbxDCPath;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}