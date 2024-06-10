
namespace Active_Directory_TSK_V1
{
    partial class frm_topluKullanici
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddUsers = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxDomains = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxOU = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonAddUsers
            // 
            this.buttonAddUsers.ActiveControl = null;
            this.buttonAddUsers.Location = new System.Drawing.Point(288, 183);
            this.buttonAddUsers.Name = "buttonAddUsers";
            this.buttonAddUsers.Size = new System.Drawing.Size(50, 50);
            this.buttonAddUsers.Style = MetroFramework.MetroColorStyle.Purple;
            this.buttonAddUsers.TabIndex = 59;
            this.buttonAddUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddUsers.TileImage = global::Active_Directory_TSK_V1.Properties.Resources.plus__1_;
            this.buttonAddUsers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAddUsers.UseSelectable = true;
            this.buttonAddUsers.UseTileImage = true;
            this.buttonAddUsers.Click += new System.EventHandler(this.buttonAddUsers_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(296, 236);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(32, 19);
            this.metroLabel8.TabIndex = 58;
            this.metroLabel8.Text = "Ekle";
            // 
            // comboBoxDomains
            // 
            this.comboBoxDomains.FormattingEnabled = true;
            this.comboBoxDomains.ItemHeight = 23;
            this.comboBoxDomains.Location = new System.Drawing.Point(159, 90);
            this.comboBoxDomains.Name = "comboBoxDomains";
            this.comboBoxDomains.Size = new System.Drawing.Size(385, 29);
            this.comboBoxDomains.TabIndex = 60;
            this.comboBoxDomains.UseSelectable = true;
            this.comboBoxDomains.SelectedIndexChanged += new System.EventHandler(this.comboBoxDomains_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 61;
            this.metroLabel2.Text = "Domain Seç:";
            // 
            // comboBoxOU
            // 
            this.comboBoxOU.FormattingEnabled = true;
            this.comboBoxOU.ItemHeight = 23;
            this.comboBoxOU.Location = new System.Drawing.Point(159, 125);
            this.comboBoxOU.Name = "comboBoxOU";
            this.comboBoxOU.Size = new System.Drawing.Size(385, 29);
            this.comboBoxOU.TabIndex = 76;
            this.comboBoxOU.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 125);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(145, 19);
            this.metroLabel4.TabIndex = 75;
            this.metroLabel4.Text = "Organization Unity Seç:";
            // 
            // frm_topluKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 403);
            this.Controls.Add(this.comboBoxOU);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.comboBoxDomains);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.buttonAddUsers);
            this.Controls.Add(this.metroLabel8);
            this.Name = "frm_topluKullanici";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Toplu Kullanıcı Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroTile buttonAddUsers;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox comboBoxDomains;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox comboBoxOU;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}