using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Active_Directory_TSK_V1
{
    public partial class frm_Register2 : MetroFramework.Forms.MetroForm
    {
        public frm_Register2()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void chbx_sifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_sifreyiGoster.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword1.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
                txtPassword1.PasswordChar = '●';
            }
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtPassword1.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre alanları boş", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtPassword1.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtPassword1.Text = "";

                MessageBox.Show("Hesabınız başarıyla oluşturuldu", "Başarıyla Kayıt Olundu.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor, lütfen şifreyi tekrar girin", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtPassword1.Text = "";
                txtPassword.Focus();
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            new frm_Login2().Show();
            this.Hide();
            this.Hide();
        }

        private void frm_Register2_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
            txtPassword1.PasswordChar = '●';
        }
    }
}