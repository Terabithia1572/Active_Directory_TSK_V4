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
    public partial class frm_GrupCreate : MetroFramework.Forms.MetroForm
    {
        public frm_GrupCreate()
        {
            InitializeComponent();
            //LoadOrganizationalUnits();
            LoadDomainControllers();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            string ldapPath = cbxOUPath.SelectedItem.ToString(); // Combobox'tan seçilen OU
            string groupName = txtGroupName.Text;
            string description = txtDescription.Text;

            try
            {
                using (DirectoryEntry ouEntry = new DirectoryEntry(ldapPath))
                {
                    using (DirectoryEntry newGroup = ouEntry.Children.Add("CN=" + groupName, "group"))
                    {
                        newGroup.Properties["sAMAccountName"].Value = groupName;
                        newGroup.Properties["description"].Value = description;
                        newGroup.CommitChanges();
                    }
                }

                MessageBox.Show("Grup başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        //private void LoadOrganizationalUnits()
        //{
        //    try
        //    {
        //        DirectoryEntry rootDSE = new DirectoryEntry(ldapPath);
        //        DirectorySearcher searcher = new DirectorySearcher(rootDSE)
        //        {
        //            Filter = "(objectClass=organizationalUnit)"
        //        };

        //        cbxOUPath.Items.Clear(); // Clear existing items

        //        foreach (SearchResult result in searcher.FindAll())
        //        {
        //            DirectoryEntry ouEntry = result.GetDirectoryEntry();
        //            cbxOUPath.Items.Add(ouEntry.Path);
        //        }

        //        if (cbxOUPath.Items.Count > 0)
        //        {
        //            cbxOUPath.SelectedIndex = 0; // Select the first OU by default
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Organization Units'ı yüklerken bir hata oluştu: {ex.Message}");
        //    }
        //}
        private void LoadDomainControllers()
        {
            try
            {
                Domain domain = Domain.GetCurrentDomain();
                foreach (DomainController dc in domain.DomainControllers)
                {
                    string ldapPath = $"LDAP://{dc.Name}";
                    cbxDCPath.Items.Add(ldapPath);
                }

                if (cbxDCPath.Items.Count > 0)
                {
                    cbxDCPath.SelectedIndex = 0; // Select the first DC by default
                    LoadOrganizationalUnits(cbxDCPath.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Domain Controllers'ı yüklerken bir hata oluştu: {ex.Message}");
            }
        }

        private void cbxDCPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDCPath.SelectedItem != null)
            {
                string selectedLdapPath = cbxDCPath.SelectedItem.ToString();
                LoadOrganizationalUnits(selectedLdapPath);
            }
        }
        private void LoadOrganizationalUnits(string ldapPath)
        {
            try
            {
                DirectoryEntry rootDSE = new DirectoryEntry(ldapPath);
                DirectorySearcher searcher = new DirectorySearcher(rootDSE)
                {
                    Filter = "(objectClass=organizationalUnit)"
                };

                cbxOUPath.Items.Clear(); // Clear existing items

                foreach (SearchResult result in searcher.FindAll())
                {
                    DirectoryEntry ouEntry = result.GetDirectoryEntry();
                    cbxOUPath.Items.Add(ouEntry.Path);
                }

                if (cbxOUPath.Items.Count > 0)
                {
                    cbxOUPath.SelectedIndex = 0; // Select the first OU by default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Organization Units'ı yüklerken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
