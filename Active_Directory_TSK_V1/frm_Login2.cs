using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.OleDb;

namespace Active_Directory_TSK_V1
{
    public partial class frm_Login2 : MetroFramework.Forms.MetroForm
    {
        public frm_Login2()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void chbx_windowsIleBaslama_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_windowsIleBaslama.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("KullaniciGirisi", "\"" + Application.ExecutablePath + "\"");
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("KullaniciGirisi");
            }
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password= '" + txtPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new AnaSayfa().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı ya da şifre. Lütfen tekrar deneyin", "Giriş Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            new frm_Register2().Show();
            this.Hide();
        }

        private void chbx_sifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_sifreyiGoster.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void frm_Login2_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }
    }
}
