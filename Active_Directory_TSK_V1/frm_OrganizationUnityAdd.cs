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
using System.DirectoryServices.ActiveDirectory;

namespace Active_Directory_TSK_V1
{
    public partial class frm_OrganizationUnityAdd : MetroFramework.Forms.MetroForm
    {
        public frm_OrganizationUnityAdd()
        {
            InitializeComponent();
        }
        private void LoadOrganizationalUnits()
        {
            try
            {
                DirectoryEntry rootDSE = new DirectoryEntry(ldapPath);
                DirectorySearcher searcher = new DirectorySearcher(rootDSE)
                {
                    Filter = "(objectClass=organizationalUnit)"
                };

                ouComboBox.Items.Clear();
                foreach (SearchResult result in searcher.FindAll())
                {
                    DirectoryEntry ouEntry = result.GetDirectoryEntry();
                    ouComboBox.Items.Add(ouEntry.Path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Meydana Geldi: {ex.Message}");
            }

        }

        private void createOuButton_Click(object sender, EventArgs e)
        {
            string selectedOUPath = ouComboBox.SelectedItem?.ToString();
            string newOuName = newOuNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(selectedOUPath))
            {
                MessageBox.Show("Lütfen Organization Unity Seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newOuName))
            {
                MessageBox.Show("Lütfen Organization Unity Adını Giriniz.");
                return;
            }

            try
            {
                CreateOrganizationalUnit(selectedOUPath, newOuName);
                MessageBox.Show("Organization Unity Başarıyla Eklendi.");
                LoadOrganizationalUnits(); // Reload OUs to show the newly added one
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Meydana Geldi: {ex.Message}");
            }
            //MessageBox.Show("Organization Unity Başarıyla Eklendi.");
            //MessageBox.Show("Lütfen Organization Unity Adını Giriniz..");
            //MessageBox.Show("Lütfen Organization Unity Seçin.");
        }
        private void CreateOrganizationalUnit(string parentOuPath, string newOuName)
        {
            DirectoryEntry parentOU = new DirectoryEntry(parentOuPath);
            DirectoryEntry newOU = parentOU.Children.Add($"OU={newOuName}", "OrganizationalUnit");
            newOU.CommitChanges();
        }

        private void frm_OrganizationUnityAdd_Load(object sender, EventArgs e)
        {
            LoadServerAddresses();
            LoadOrganizationalUnits();
        }

        private void cbxDCPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLdapPath();
        }
        private void LoadServerAddresses()
        {
            try
            {
                Forest currentForest = Forest.GetCurrentForest();
                List<DomainController> domainControllers = new List<DomainController>();

                foreach (Domain domain in currentForest.Domains)
                {
                    domainControllers.AddRange(domain.FindAllDiscoverableDomainControllers().Cast<DomainController>());
                }

                foreach (DomainController dc in domainControllers)
                {
                    cbxDCPath.Items.Add(dc.Name);
                }

                if (cbxDCPath.Items.Count > 0)
                {
                    cbxDCPath.SelectedIndex = 0;
                    UpdateLdapPath();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading server addresses: {ex.Message}");
            }
        }

        private void UpdateLdapPath()
        {
            string selectedServer = cbxDCPath.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedServer))
            {
                ldapPath = $"LDAP://{selectedServer}";
                LoadOrganizationalUnits(); // Reload organizational units with the new LDAP path
            }
        }
        private string ldapPath = "LDAP://DC=kkk,DC=tsk"; // This will be updated dynamically

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }
    }
}
