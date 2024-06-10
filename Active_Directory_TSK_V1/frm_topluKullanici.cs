using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.IO;

namespace Active_Directory_TSK_V1
{
    public partial class frm_topluKullanici : MetroFramework.Forms.MetroForm
    {
        public frm_topluKullanici()
        {
            InitializeComponent();
            LoadDomains();
            
        }

        private void LoadDomains()
        {
            try
            {
                foreach (Domain domain in Forest.GetCurrentForest().Domains)
                {
                    comboBoxDomains.Items.Add(domain.Name);
                }
                if (comboBoxDomains.Items.Count > 0)
                {
                    comboBoxDomains.SelectedIndex = 0; // İlk domain'i seçili yap
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Domainler yüklenirken hata oluştu: {ex.Message}");
            }
        }
        private void LoadOrganizationUnits(string domain)
        {
            try
            {
                comboBoxOU.Items.Clear();
                using (var context = new PrincipalContext(ContextType.Domain, domain))
                {
                    string domainComponent = string.Join(",", domain.Split('.').Select(dc => $"DC={dc}"));
                    string ldapPath = $"LDAP://{domainComponent}";
                    using (var rootDSE = new DirectoryEntry(ldapPath))
                    using (var searcher = new DirectorySearcher(rootDSE))
                    {
                        searcher.Filter = "(objectCategory=organizationalUnit)";
                        searcher.SearchScope = SearchScope.Subtree;

                        foreach (SearchResult entry in searcher.FindAll())
                        {
                            DirectoryEntry directoryEntry = entry.GetDirectoryEntry();
                            comboBoxOU.Items.Add(directoryEntry.Path);
                        }
                    }
                }
                if (comboBoxOU.Items.Count > 0)
                {
                    comboBoxOU.SelectedIndex = 0; // İlk OU'yu seçili yap
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OU'lar yüklenirken hata oluştu: {ex.Message}");
            }
        }


        private void AddUsersFromCsv(string filePath, string domain, string ou)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                if (lines.Length == 0)
                {
                    MessageBox.Show("CSV dosyası boş.");
                    return;
                }

                var headers = lines[0].Split(',');
                int expectedColumnCount = 7; // Beklenen sütun sayısı

                if (headers.Length < expectedColumnCount)
                {
                    MessageBox.Show("CSV dosyasındaki sütun sayısı beklenenden az.");
                    return;
                }

                int nameIndex = Array.IndexOf(headers, "Name");
                int surnameIndex = Array.IndexOf(headers, "Surname");
                int userPrincipalNameIndex = Array.IndexOf(headers, "UserPrincipalName");
                int accountPasswordIndex = Array.IndexOf(headers, "AccountPassword");
                int descriptionIndex = Array.IndexOf(headers, "Description");
                int displayNameIndex = Array.IndexOf(headers, "DisplayName");
                int logonNameIndex = Array.IndexOf(headers, "logonName");

                if (nameIndex == -1 || surnameIndex == -1 || userPrincipalNameIndex == -1 ||
                    accountPasswordIndex == -1 || descriptionIndex == -1 || displayNameIndex == -1 || logonNameIndex == -1)
                {
                    MessageBox.Show("CSV dosyasındaki sütun adları beklenenden farklı.");
                    return;
                }

                using (var context = new PrincipalContext(ContextType.Domain, domain))
                {
                    foreach (var line in lines.Skip(1))
                    {
                        var values = line.Split(',');

                        if (values.Length < expectedColumnCount)
                        {
                            MessageBox.Show($"Bir satırda beklenenden az sütun var: {line}");
                            continue;
                        }

                        string name = values[nameIndex];
                        string surname = values[surnameIndex];
                        string userPrincipalName = values[userPrincipalNameIndex];
                        string accountPassword = values[accountPasswordIndex];
                        string description = values[descriptionIndex];
                        string displayName = values[displayNameIndex];
                        string logonName = values[logonNameIndex];

                        var user = new UserPrincipal(context)
                        {
                            Name = name,
                            Surname = surname,
                            UserPrincipalName = userPrincipalName,
                            Description = description,
                            DisplayName = displayName,
                            SamAccountName = logonName, // Logon name olarak SamAccountName kullanılıyor
                            PasswordNeverExpires = true,
                            Enabled = true
                        };

                        user.SetPassword(accountPassword);
                        user.Save();

                        // Move user to the selected OU
                        DirectoryEntry directoryEntry = (DirectoryEntry)user.GetUnderlyingObject();
                        directoryEntry.MoveTo(new DirectoryEntry(ou));
                    }
                }

                MessageBox.Show("Kullanıcılar başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void buttonAddUsers_Click(object sender, EventArgs e)
        {
            if (comboBoxDomains.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir domain seçin.");
                return;
            }

            if (comboBoxOU.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir OU seçin.");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|TXT files (*.txt)|*.txt",
                Title = "CSV veya TXT Dosyasını Seçin"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string selectedDomain = comboBoxDomains.SelectedItem.ToString();
                string selectedOU = comboBoxOU.SelectedItem.ToString();
                AddUsersFromCsv(filePath, selectedDomain, selectedOU);
            }
        }

        private void comboBoxDomains_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDomains.SelectedItem != null)
            {
                LoadOrganizationUnits(comboBoxDomains.SelectedItem.ToString());
            }
        }
    }
}
