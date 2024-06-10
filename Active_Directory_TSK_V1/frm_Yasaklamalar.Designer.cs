
namespace Active_Directory_TSK_V1
{
    partial class frm_Yasaklamalar
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
            this.chkDisableCMD = new MetroFramework.Controls.MetroCheckBox();
            this.chkDisablePowerShell = new MetroFramework.Controls.MetroCheckBox();
            this.chkDisableNetworkSettings = new MetroFramework.Controls.MetroCheckBox();
            this.chkHideCDrive = new MetroFramework.Controls.MetroCheckBox();
            this.chkDisableAccessCDrive = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnApplyGPO = new MetroFramework.Controls.MetroTile();
            this.comboServer = new MetroFramework.Controls.MetroComboBox();
            this.comboOU = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtGPOName = new MetroFramework.Controls.MetroTextBox();
            this.lblGPOName = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // chkDisableCMD
            // 
            this.chkDisableCMD.AutoSize = true;
            this.chkDisableCMD.Location = new System.Drawing.Point(55, 79);
            this.chkDisableCMD.Name = "chkDisableCMD";
            this.chkDisableCMD.Size = new System.Drawing.Size(91, 15);
            this.chkDisableCMD.TabIndex = 0;
            this.chkDisableCMD.Text = "CMD Yasakla";
            this.chkDisableCMD.UseSelectable = true;
            // 
            // chkDisablePowerShell
            // 
            this.chkDisablePowerShell.AutoSize = true;
            this.chkDisablePowerShell.Location = new System.Drawing.Point(55, 100);
            this.chkDisablePowerShell.Name = "chkDisablePowerShell";
            this.chkDisablePowerShell.Size = new System.Drawing.Size(122, 15);
            this.chkDisablePowerShell.TabIndex = 0;
            this.chkDisablePowerShell.Text = "PowerShell Yasakla";
            this.chkDisablePowerShell.UseSelectable = true;
            // 
            // chkDisableNetworkSettings
            // 
            this.chkDisableNetworkSettings.AutoSize = true;
            this.chkDisableNetworkSettings.Location = new System.Drawing.Point(55, 121);
            this.chkDisableNetworkSettings.Name = "chkDisableNetworkSettings";
            this.chkDisableNetworkSettings.Size = new System.Drawing.Size(132, 15);
            this.chkDisableNetworkSettings.TabIndex = 0;
            this.chkDisableNetworkSettings.Text = "Ağ Ayarlarını Yasakla";
            this.chkDisableNetworkSettings.UseSelectable = true;
            // 
            // chkHideCDrive
            // 
            this.chkHideCDrive.AutoSize = true;
            this.chkHideCDrive.Location = new System.Drawing.Point(55, 142);
            this.chkHideCDrive.Name = "chkHideCDrive";
            this.chkHideCDrive.Size = new System.Drawing.Size(87, 15);
            this.chkHideCDrive.TabIndex = 0;
            this.chkHideCDrive.Text = "C Diski Gizle";
            this.chkHideCDrive.UseSelectable = true;
            // 
            // chkDisableAccessCDrive
            // 
            this.chkDisableAccessCDrive.AutoSize = true;
            this.chkDisableAccessCDrive.Location = new System.Drawing.Point(55, 163);
            this.chkDisableAccessCDrive.Name = "chkDisableAccessCDrive";
            this.chkDisableAccessCDrive.Size = new System.Drawing.Size(110, 15);
            this.chkDisableAccessCDrive.TabIndex = 0;
            this.chkDisableAccessCDrive.Text = "C Diskini Yasakla";
            this.chkDisableAccessCDrive.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(318, 355);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 19);
            this.metroLabel8.TabIndex = 56;
            this.metroLabel8.Text = "Yasakla";
            // 
            // btnApplyGPO
            // 
            this.btnApplyGPO.ActiveControl = null;
            this.btnApplyGPO.Location = new System.Drawing.Point(318, 302);
            this.btnApplyGPO.Name = "btnApplyGPO";
            this.btnApplyGPO.Size = new System.Drawing.Size(50, 50);
            this.btnApplyGPO.Style = MetroFramework.MetroColorStyle.Red;
            this.btnApplyGPO.TabIndex = 57;
            this.btnApplyGPO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApplyGPO.TileImage = global::Active_Directory_TSK_V1.Properties.Resources.close_circular_button_of_a_cross__1_;
            this.btnApplyGPO.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApplyGPO.UseSelectable = true;
            this.btnApplyGPO.UseTileImage = true;
            this.btnApplyGPO.Click += new System.EventHandler(this.btnApplyGPO_Click);
            // 
            // comboServer
            // 
            this.comboServer.FormattingEnabled = true;
            this.comboServer.ItemHeight = 23;
            this.comboServer.Location = new System.Drawing.Point(395, 79);
            this.comboServer.Name = "comboServer";
            this.comboServer.Size = new System.Drawing.Size(345, 29);
            this.comboServer.TabIndex = 77;
            this.comboServer.UseSelectable = true;
            this.comboServer.SelectedIndexChanged += new System.EventHandler(this.comboServer_SelectedIndexChanged);
            // 
            // comboOU
            // 
            this.comboOU.FormattingEnabled = true;
            this.comboOU.ItemHeight = 23;
            this.comboOU.Location = new System.Drawing.Point(395, 114);
            this.comboOU.Name = "comboOU";
            this.comboOU.Size = new System.Drawing.Size(345, 29);
            this.comboOU.TabIndex = 78;
            this.comboOU.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(250, 79);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 75;
            this.metroLabel5.Text = "Domain Seçin:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(250, 114);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 76;
            this.metroLabel4.Text = "GPO Seç:";
            // 
            // txtGPOName
            // 
            // 
            // 
            // 
            this.txtGPOName.CustomButton.Image = null;
            this.txtGPOName.CustomButton.Location = new System.Drawing.Point(323, 1);
            this.txtGPOName.CustomButton.Name = "";
            this.txtGPOName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGPOName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGPOName.CustomButton.TabIndex = 1;
            this.txtGPOName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGPOName.CustomButton.UseSelectable = true;
            this.txtGPOName.CustomButton.Visible = false;
            this.txtGPOName.Lines = new string[0];
            this.txtGPOName.Location = new System.Drawing.Point(395, 154);
            this.txtGPOName.MaxLength = 32767;
            this.txtGPOName.Name = "txtGPOName";
            this.txtGPOName.PasswordChar = '\0';
            this.txtGPOName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGPOName.SelectedText = "";
            this.txtGPOName.SelectionLength = 0;
            this.txtGPOName.SelectionStart = 0;
            this.txtGPOName.ShortcutsEnabled = true;
            this.txtGPOName.Size = new System.Drawing.Size(345, 23);
            this.txtGPOName.TabIndex = 79;
            this.txtGPOName.UseSelectable = true;
            this.txtGPOName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGPOName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblGPOName
            // 
            this.lblGPOName.AutoSize = true;
            this.lblGPOName.Location = new System.Drawing.Point(250, 154);
            this.lblGPOName.Name = "lblGPOName";
            this.lblGPOName.Size = new System.Drawing.Size(96, 19);
            this.lblGPOName.TabIndex = 76;
            this.lblGPOName.Text = "GPO Adını Gir:";
            // 
            // frm_Yasaklamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGPOName);
            this.Controls.Add(this.comboServer);
            this.Controls.Add(this.comboOU);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblGPOName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnApplyGPO);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.chkDisableAccessCDrive);
            this.Controls.Add(this.chkHideCDrive);
            this.Controls.Add(this.chkDisableNetworkSettings);
            this.Controls.Add(this.chkDisablePowerShell);
            this.Controls.Add(this.chkDisableCMD);
            this.Name = "frm_Yasaklamalar";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Yasaklamalar";
            this.Load += new System.EventHandler(this.frm_Yasaklamalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chkDisableCMD;
        private MetroFramework.Controls.MetroCheckBox chkDisablePowerShell;
        private MetroFramework.Controls.MetroCheckBox chkDisableNetworkSettings;
        private MetroFramework.Controls.MetroCheckBox chkHideCDrive;
        private MetroFramework.Controls.MetroCheckBox chkDisableAccessCDrive;
        private MetroFramework.Controls.MetroTile btnApplyGPO;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox comboServer;
        private MetroFramework.Controls.MetroComboBox comboOU;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtGPOName;
        private MetroFramework.Controls.MetroLabel lblGPOName;
    }
}