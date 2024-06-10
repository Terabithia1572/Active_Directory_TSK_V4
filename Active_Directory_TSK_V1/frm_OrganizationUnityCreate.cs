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
    public partial class frm_OrganizationUnityCreate : MetroFramework.Forms.MetroForm
    {
        public frm_OrganizationUnityCreate()
        {
            InitializeComponent();
            LoadLDAPPaths();
        }

        private void CreateOrganizationalUnit(string ouName)
        {
            if (comboBoxLDAPPaths.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir LDAP yolu seçin.");
                return;
            }

            string ldapPath = comboBoxLDAPPaths.SelectedItem.ToString(); // Get selected LDAP path

            try
            {
                using (DirectoryEntry rootDSE = new DirectoryEntry(ldapPath))
                {
                    DirectoryEntry newOU = rootDSE.Children.Add($"OU={ouName}", "OrganizationalUnit");
                    newOU.CommitChanges();
                }

                MessageBox.Show("Organizational Unit Başarılı Bir Şekilde Oluşturuldu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Meydana Geldi: {ex.Message}");
            }
        }
        private void LoadLDAPPaths()
        {
            try
            {
                using (DirectoryEntry rootDSE = new DirectoryEntry("LDAP://RootDSE"))
                {
                    // Get the naming contexts from RootDSE
                    string[] namingContexts = rootDSE.Properties["namingContexts"].OfType<string>().ToArray();

                    foreach (string context in namingContexts)
                    {
                        comboBoxLDAPPaths.Items.Add($"LDAP://{context}");
                    }

                    if (comboBoxLDAPPaths.Items.Count > 0)
                    {
                        comboBoxLDAPPaths.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load LDAP paths: {ex.Message}");
            }
        }

        private void createOUButton_Click(object sender, EventArgs e)
        {
            string ouName = ouNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(ouName))
            {
                MessageBox.Show("Lütfen Organization Unity Adı Girin.");
                return;
            }

            CreateOrganizationalUnit(ouName);
        }

    }
}
  