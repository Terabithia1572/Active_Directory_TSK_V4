
namespace Active_Directory_TSK_V1
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconTaskBar = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_notify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sag_tik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kullaniciYetkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciEkleStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OUEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaDurumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGöreviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTürüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.programıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_OU = new MetroFramework.Controls.MetroTile();
            this.btn_OuAdd = new MetroFramework.Controls.MetroTile();
            this.btn_userCreate = new MetroFramework.Controls.MetroTile();
            this.btn_groupCreate = new MetroFramework.Controls.MetroTile();
            this.btn_Yasakla = new MetroFramework.Controls.MetroTile();
            this.btn_userAdd = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_kullaniciYetki = new MetroFramework.Controls.MetroTile();
            this.btn_odeme = new MetroFramework.Controls.MetroTile();
            this.ortapanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cms_notify.SuspendLayout();
            this.sag_tik.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // notifyIconTaskBar
            // 
            this.notifyIconTaskBar.ContextMenuStrip = this.cms_notify;
            this.notifyIconTaskBar.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTaskBar.Icon")));
            this.notifyIconTaskBar.Text = "Yurt Kayıt Kontrol";
            this.notifyIconTaskBar.Visible = true;
            // 
            // cms_notify
            // 
            this.cms_notify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.cms_notify.Name = "contextMenuStrip1";
            this.cms_notify.Size = new System.Drawing.Size(109, 70);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // sag_tik
            // 
            this.sag_tik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullaniciYetkiToolStripMenuItem,
            this.kullaniciEkleStripMenuItem,
            this.OUEkleToolStripMenuItem,
            this.OUToolStripMenuItem,
            this.grupOlusturToolStripMenuItem,
            this.odaDurumToolStripMenuItem,
            this.personelGöreviToolStripMenuItem,
            this.kullanıcıTürüToolStripMenuItem,
            this.gizleToolStripMenuItem1,
            this.programıKapatToolStripMenuItem});
            this.sag_tik.Name = "sag_tik";
            this.sag_tik.Size = new System.Drawing.Size(198, 224);
            // 
            // kullaniciYetkiToolStripMenuItem
            // 
            this.kullaniciYetkiToolStripMenuItem.Name = "kullaniciYetkiToolStripMenuItem";
            this.kullaniciYetkiToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.kullaniciYetkiToolStripMenuItem.Text = "Kullanıcı Yetkileri";
            this.kullaniciYetkiToolStripMenuItem.Click += new System.EventHandler(this.kullaniciYetkiToolStripMenuItem_Click);
            // 
            // kullaniciEkleStripMenuItem
            // 
            this.kullaniciEkleStripMenuItem.Name = "kullaniciEkleStripMenuItem";
            this.kullaniciEkleStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.kullaniciEkleStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullaniciEkleStripMenuItem.Click += new System.EventHandler(this.kullaniciEkleStripMenuItem_Click);
            // 
            // OUEkleToolStripMenuItem
            // 
            this.OUEkleToolStripMenuItem.Name = "OUEkleToolStripMenuItem";
            this.OUEkleToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.OUEkleToolStripMenuItem.Text = "Organization Unity Ekle";
            this.OUEkleToolStripMenuItem.Click += new System.EventHandler(this.OUEkleToolStripMenuItem_Click);
            // 
            // OUToolStripMenuItem
            // 
            this.OUToolStripMenuItem.Name = "OUToolStripMenuItem";
            this.OUToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.OUToolStripMenuItem.Text = "OU İç İçe Ekle";
            this.OUToolStripMenuItem.Click += new System.EventHandler(this.OUToolStripMenuItem_Click);
            // 
            // grupOlusturToolStripMenuItem
            // 
            this.grupOlusturToolStripMenuItem.Name = "grupOlusturToolStripMenuItem";
            this.grupOlusturToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.grupOlusturToolStripMenuItem.Text = "Grup Oluştur";
            this.grupOlusturToolStripMenuItem.Click += new System.EventHandler(this.grupOlusturToolStripMenuItem_Click);
            // 
            // odaDurumToolStripMenuItem
            // 
            this.odaDurumToolStripMenuItem.Name = "odaDurumToolStripMenuItem";
            this.odaDurumToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.odaDurumToolStripMenuItem.Text = "Oda Durum";
            // 
            // personelGöreviToolStripMenuItem
            // 
            this.personelGöreviToolStripMenuItem.Name = "personelGöreviToolStripMenuItem";
            this.personelGöreviToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.personelGöreviToolStripMenuItem.Text = "Personel Görevi";
            // 
            // kullanıcıTürüToolStripMenuItem
            // 
            this.kullanıcıTürüToolStripMenuItem.Name = "kullanıcıTürüToolStripMenuItem";
            this.kullanıcıTürüToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.kullanıcıTürüToolStripMenuItem.Text = "Kullanıcı Türü";
            // 
            // gizleToolStripMenuItem1
            // 
            this.gizleToolStripMenuItem1.Name = "gizleToolStripMenuItem1";
            this.gizleToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.gizleToolStripMenuItem1.Text = "Gizle";
            this.gizleToolStripMenuItem1.Click += new System.EventHandler(this.gizleToolStripMenuItem1_Click);
            // 
            // programıKapatToolStripMenuItem
            // 
            this.programıKapatToolStripMenuItem.Name = "programıKapatToolStripMenuItem";
            this.programıKapatToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.programıKapatToolStripMenuItem.Text = "Programı Kapat";
            this.programıKapatToolStripMenuItem.Click += new System.EventHandler(this.programıKapatToolStripMenuItem_Click);
            // 
            // btn_OU
            // 
            this.btn_OU.ActiveControl = null;
            this.btn_OU.Location = new System.Drawing.Point(3, 49);
            this.btn_OU.Name = "btn_OU";
            this.btn_OU.Size = new System.Drawing.Size(190, 40);
            this.btn_OU.TabIndex = 2;
            this.btn_OU.Text = "Organization Unity Oluşturma";
            this.btn_OU.UseSelectable = true;
            this.btn_OU.Click += new System.EventHandler(this.btn_OU_Click);
            // 
            // btn_OuAdd
            // 
            this.btn_OuAdd.ActiveControl = null;
            this.btn_OuAdd.Location = new System.Drawing.Point(3, 95);
            this.btn_OuAdd.Name = "btn_OuAdd";
            this.btn_OuAdd.Size = new System.Drawing.Size(190, 40);
            this.btn_OuAdd.TabIndex = 2;
            this.btn_OuAdd.Text = "İç İçe  Organization Unity \r\nEkleme\r\n\r\n";
            this.btn_OuAdd.UseSelectable = true;
            this.btn_OuAdd.Click += new System.EventHandler(this.btn_OuAdd_Click);
            // 
            // btn_userCreate
            // 
            this.btn_userCreate.ActiveControl = null;
            this.btn_userCreate.Location = new System.Drawing.Point(3, 141);
            this.btn_userCreate.Name = "btn_userCreate";
            this.btn_userCreate.Size = new System.Drawing.Size(190, 40);
            this.btn_userCreate.TabIndex = 2;
            this.btn_userCreate.Text = "Kullanıcı Oluşturma";
            this.btn_userCreate.UseSelectable = true;
            this.btn_userCreate.Click += new System.EventHandler(this.btn_userCreate_Click);
            // 
            // btn_groupCreate
            // 
            this.btn_groupCreate.ActiveControl = null;
            this.btn_groupCreate.Location = new System.Drawing.Point(3, 187);
            this.btn_groupCreate.Name = "btn_groupCreate";
            this.btn_groupCreate.Size = new System.Drawing.Size(190, 40);
            this.btn_groupCreate.TabIndex = 2;
            this.btn_groupCreate.Text = "Grup Oluşturma";
            this.btn_groupCreate.UseSelectable = true;
            this.btn_groupCreate.Click += new System.EventHandler(this.btn_groupCreate_Click);
            // 
            // btn_Yasakla
            // 
            this.btn_Yasakla.ActiveControl = null;
            this.btn_Yasakla.Location = new System.Drawing.Point(3, 233);
            this.btn_Yasakla.Name = "btn_Yasakla";
            this.btn_Yasakla.Size = new System.Drawing.Size(190, 40);
            this.btn_Yasakla.TabIndex = 2;
            this.btn_Yasakla.Text = "Yasaklamalar";
            this.btn_Yasakla.UseSelectable = true;
            this.btn_Yasakla.Click += new System.EventHandler(this.btn_Yasakla_Click);
            // 
            // btn_userAdd
            // 
            this.btn_userAdd.ActiveControl = null;
            this.btn_userAdd.Location = new System.Drawing.Point(3, 325);
            this.btn_userAdd.Name = "btn_userAdd";
            this.btn_userAdd.Size = new System.Drawing.Size(190, 40);
            this.btn_userAdd.TabIndex = 2;
            this.btn_userAdd.Text = "Toplu Kullanıcı Ekle";
            this.btn_userAdd.UseSelectable = true;
            this.btn_userAdd.Click += new System.EventHandler(this.btn_userAdd_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btn_kullaniciYetki);
            this.flowLayoutPanel1.Controls.Add(this.btn_OU);
            this.flowLayoutPanel1.Controls.Add(this.btn_OuAdd);
            this.flowLayoutPanel1.Controls.Add(this.btn_userCreate);
            this.flowLayoutPanel1.Controls.Add(this.btn_groupCreate);
            this.flowLayoutPanel1.Controls.Add(this.btn_Yasakla);
            this.flowLayoutPanel1.Controls.Add(this.btn_odeme);
            this.flowLayoutPanel1.Controls.Add(this.btn_userAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(213, 584);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // btn_kullaniciYetki
            // 
            this.btn_kullaniciYetki.ActiveControl = null;
            this.btn_kullaniciYetki.Location = new System.Drawing.Point(3, 3);
            this.btn_kullaniciYetki.Name = "btn_kullaniciYetki";
            this.btn_kullaniciYetki.Size = new System.Drawing.Size(190, 40);
            this.btn_kullaniciYetki.TabIndex = 2;
            this.btn_kullaniciYetki.Text = "Kullanıcı Yetkileri";
            this.btn_kullaniciYetki.UseSelectable = true;
            this.btn_kullaniciYetki.UseTileImage = true;
            this.btn_kullaniciYetki.Click += new System.EventHandler(this.btn_kullaniciYetki_Click);
            // 
            // btn_odeme
            // 
            this.btn_odeme.ActiveControl = null;
            this.btn_odeme.Location = new System.Drawing.Point(3, 279);
            this.btn_odeme.Name = "btn_odeme";
            this.btn_odeme.Size = new System.Drawing.Size(190, 40);
            this.btn_odeme.TabIndex = 2;
            this.btn_odeme.Text = "Klasör Yetkileri Güncelleme";
            this.btn_odeme.UseSelectable = true;
            // 
            // ortapanel
            // 
            this.ortapanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ortapanel.HorizontalScrollbarBarColor = true;
            this.ortapanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ortapanel.HorizontalScrollbarSize = 10;
            this.ortapanel.Location = new System.Drawing.Point(233, 60);
            this.ortapanel.Name = "ortapanel";
            this.ortapanel.Size = new System.Drawing.Size(897, 584);
            this.ortapanel.TabIndex = 7;
            this.ortapanel.VerticalScrollbarBarColor = true;
            this.ortapanel.VerticalScrollbarHighlightOnWheel = false;
            this.ortapanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(266, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(497, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "18.DÖNEM OBİ: MU.ASB.ÇVŞ YUNUS İNAN [2024-B.37] TARAFINDAN YAPILMIŞTIR.";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ortapanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaSayfa_FormClosing);
            this.cms_notify.ResumeLayout(false);
            this.sag_tik.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconTaskBar;
        private System.Windows.Forms.ContextMenuStrip cms_notify;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip sag_tik;
        private System.Windows.Forms.ToolStripMenuItem kullaniciYetkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciEkleStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OUEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaDurumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGöreviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıTürüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem programıKapatToolStripMenuItem;
        private MetroFramework.Controls.MetroTile btn_OU;
        private MetroFramework.Controls.MetroTile btn_OuAdd;
        private MetroFramework.Controls.MetroTile btn_userCreate;
        private MetroFramework.Controls.MetroTile btn_groupCreate;
        private MetroFramework.Controls.MetroTile btn_Yasakla;
        private MetroFramework.Controls.MetroTile btn_userAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile btn_kullaniciYetki;
        private MetroFramework.Controls.MetroTile btn_odeme;
        private MetroFramework.Controls.MetroPanel ortapanel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

