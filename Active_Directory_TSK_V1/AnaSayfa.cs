using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Active_Directory_TSK_V1
{
    public partial class AnaSayfa : MetroFramework.Forms.MetroForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        //null
        private void btn_kullaniciYetki_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_KullaniciYetki frm_kullaniciyetki = new frm_KullaniciYetki();
            frm_kullaniciyetki.MdiParent = this;
            frm_kullaniciyetki.TopLevel = false;
            ortapanel.Controls.Add(frm_kullaniciyetki);
            frm_kullaniciyetki.Show();
            frm_kullaniciyetki.Dock = DockStyle.Fill;
            frm_kullaniciyetki.BringToFront();
        }

        private void btn_OU_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_OrganizationUnityCreate frm_oucreate = new frm_OrganizationUnityCreate();
            frm_oucreate.MdiParent = this;
            frm_oucreate.TopLevel = false;
            ortapanel.Controls.Add(frm_oucreate);
            frm_oucreate.Show();
            frm_oucreate.Dock = DockStyle.Fill;
            frm_oucreate.BringToFront();
        }

        private void btn_OuAdd_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_OrganizationUnityAdd frm_ouAdd = new frm_OrganizationUnityAdd();
            frm_ouAdd.MdiParent = this;
            frm_ouAdd.TopLevel = false;
            ortapanel.Controls.Add(frm_ouAdd);
            frm_ouAdd.Show();
            frm_ouAdd.Dock = DockStyle.Fill;
            frm_ouAdd.BringToFront();
        }

        private void btn_userCreate_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_KullaniciEkle frm_userAdd = new frm_KullaniciEkle();
            frm_userAdd.MdiParent = this;
            frm_userAdd.TopLevel = false;
            ortapanel.Controls.Add(frm_userAdd);
            frm_userAdd.Show();
            frm_userAdd.Dock = DockStyle.Fill;
            frm_userAdd.BringToFront();
        }

        private void btn_groupCreate_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_GrupCreate frm_groupCreate = new frm_GrupCreate();
            frm_groupCreate.MdiParent = this;
            frm_groupCreate.TopLevel = false;
            ortapanel.Controls.Add(frm_groupCreate);
            frm_groupCreate.Show();
            frm_groupCreate.Dock = DockStyle.Fill;
            frm_groupCreate.BringToFront();
        }

        private void gizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kullaniciYetkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_KullaniciYetki frm_kullaniciyetki = new frm_KullaniciYetki();
            frm_kullaniciyetki.MdiParent = this;
            frm_kullaniciyetki.TopLevel = false;
            ortapanel.Controls.Add(frm_kullaniciyetki);
            frm_kullaniciyetki.Show();
            frm_kullaniciyetki.Dock = DockStyle.Fill;
            frm_kullaniciyetki.BringToFront();
        }

        private void kullaniciEkleStripMenuItem_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_KullaniciEkle frm_userAdd = new frm_KullaniciEkle();
            frm_userAdd.MdiParent = this;
            frm_userAdd.TopLevel = false;
            ortapanel.Controls.Add(frm_userAdd);
            frm_userAdd.Show();
            frm_userAdd.Dock = DockStyle.Fill;
            frm_userAdd.BringToFront();
        }

        private void OUEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_OrganizationUnityCreate frm_oucreate = new frm_OrganizationUnityCreate();
            frm_oucreate.MdiParent = this;
            frm_oucreate.TopLevel = false;
            ortapanel.Controls.Add(frm_oucreate);
            frm_oucreate.Show();
            frm_oucreate.Dock = DockStyle.Fill;
            frm_oucreate.BringToFront();
        }

        private void OUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_OrganizationUnityAdd frm_ouAdd = new frm_OrganizationUnityAdd();
            frm_ouAdd.MdiParent = this;
            frm_ouAdd.TopLevel = false;
            ortapanel.Controls.Add(frm_ouAdd);
            frm_ouAdd.Show();
            frm_ouAdd.Dock = DockStyle.Fill;
            frm_ouAdd.BringToFront();
        }

        private void grupOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_GrupCreate frm_groupCreate = new frm_GrupCreate();
            frm_groupCreate.MdiParent = this;
            frm_groupCreate.TopLevel = false;
            ortapanel.Controls.Add(frm_groupCreate);
            frm_groupCreate.Show();
            frm_groupCreate.Dock = DockStyle.Fill;
            frm_groupCreate.BringToFront();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Yasakla_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_Yasaklamalar frm_Yasaklamalar = new frm_Yasaklamalar();
            frm_Yasaklamalar.MdiParent = this;
            frm_Yasaklamalar.TopLevel = false;
            ortapanel.Controls.Add(frm_Yasaklamalar);
            frm_Yasaklamalar.Show();
            frm_Yasaklamalar.Dock = DockStyle.Fill;
            frm_Yasaklamalar.BringToFront();
        }

        private void btn_userAdd_Click(object sender, EventArgs e)
        {
            ortapanel.Controls.Clear();
            frm_topluKullanici frm_topluKullanici = new frm_topluKullanici();
            frm_topluKullanici.MdiParent = this;
            frm_topluKullanici.TopLevel = false;
            ortapanel.Controls.Add(frm_topluKullanici);
            frm_topluKullanici.Show();
            frm_topluKullanici.Dock = DockStyle.Fill;
            frm_topluKullanici.BringToFront();
        }
    }
}
