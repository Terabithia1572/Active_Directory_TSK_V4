using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;

namespace Active_Directory_TSK_V1
{
    public partial class frm_KullaniciEkle : MetroFramework.Forms.MetroForm
    {
        public frm_KullaniciEkle()
        {
            InitializeComponent();
            LoadOrganizationalUnits();
        }

        private void frm_KullaniciEkle_Load(object sender, EventArgs e)
        {
            if (cbxOUPath.Items.Count > 0)
            {
                cbxOUPath.SelectedIndex = 0;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string ldapPath = cbxOUPath.SelectedItem.ToString(); // Combobox'tan seçilen OU
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string fullName = txtFullName.Text + " " + (firstName + " " + lastName);
            string userLogon = txtUserLogon.Text;
            string password = txtPassword.Text;

            try
            {
                using (DirectoryEntry ouEntry = new DirectoryEntry(ldapPath))
                {
                    using (DirectoryEntry newUser = ouEntry.Children.Add("CN=" + fullName, "user"))
                    {
                        newUser.Properties["samAccountName"].Value = userLogon;
                        newUser.Properties["userPrincipalName"].Value = userLogon + "@kkk.tsk"; // Domain isminizi değiştirin
                        newUser.Properties["givenName"].Value = firstName;
                        newUser.Properties["sn"].Value = lastName;
                        newUser.Properties["displayName"].Value = fullName;
                        newUser.CommitChanges();

                        newUser.Invoke("SetPassword", new object[] { password });
                        newUser.Properties["userAccountControl"].Value = 0x200; // Normal account
                        newUser.CommitChanges();
                    }
                }

                MessageBox.Show("Kullanıcı Başarıyla Eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void LoadOrganizationalUnits()
        {
            try
            {
                string ldapPath = "LDAP://DC=kkk,DC=tsk"; // Domain'inizin LDAP yolu
                DirectoryEntry rootDSE = new DirectoryEntry(ldapPath);
                DirectorySearcher searcher = new DirectorySearcher(rootDSE)
                {
                    Filter = "(objectClass=organizationalUnit)"
                };

                foreach (SearchResult result in searcher.FindAll())
                {
                    DirectoryEntry ouEntry = result.GetDirectoryEntry();
                    cbxOUPath.Items.Add(ouEntry.Path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Oluştu: {ex.Message}");
            }
        }
    }
}
