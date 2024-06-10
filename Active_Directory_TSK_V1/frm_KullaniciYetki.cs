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
using System.IO;
using System.Security.AccessControl;

namespace Active_Directory_TSK_V1
{
    public partial class frm_KullaniciYetki : MetroFramework.Forms.MetroForm
    {
        public frm_KullaniciYetki()
        {
            InitializeComponent();
            LoadDrives();
            LoadLDAPPaths();
        }
        private void LoadDrives()
        {
            comboBoxDrives.Items.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Network || drive.DriveType == DriveType.Fixed)
                {
                    comboBoxDrives.Items.Add(drive.Name);
                }
            }

            if (comboBoxDrives.Items.Count > 0)
            {
                comboBoxDrives.SelectedIndex = 0;
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
                MessageBox.Show($"Sunucu Yolu Yüklenirken Hata Oluştu: {ex.Message}");
            }
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            string username = textBoxUsername.Text;
            string selectedDrive = comboBoxDrives.SelectedItem.ToString();
            string folderName = textBoxFolderName.Text;
            string domainName = textBoxDomain.Text; // Domain name alınan textbox
            string path = Path.Combine(selectedDrive, folderName, username);
            string selectedServer = comboBoxLDAPPaths.SelectedItem.ToString();

            if (UserExists(username, selectedServer))
            {
                if (Directory.Exists(path))
                {
                    labelResult.ForeColor = System.Drawing.Color.Red;
                    labelResult.Text = $"{folderName} KLASÖRÜ ZATEN MEVCUT";
                }
                else
                {
                    CreateDirectoryWithPermissions(path, username, domainName);
                    labelResult.ForeColor = System.Drawing.Color.Green;
                    labelResult.Text = "KLASÖR OLUŞTURMA BAŞARILI";
                }
            }
            else
            {
                labelResult.ForeColor = System.Drawing.Color.Magenta;
                labelResult.Text = $"{username} KULLANICI HENÜZ SİSTEMDE YOK";
            }
        }
        private bool UserExists(string username, string server)
        {
            try
            {
                DirectoryEntry entry = new DirectoryEntry(server);
                DirectorySearcher searcher = new DirectorySearcher(entry)
                {
                    Filter = $"(samaccountname={username})"
                };
                SearchResult result = searcher.FindOne();

                return result != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kullanıcı varlığı kontrol edilirken hata oluştu: { ex.Message}");
                return false;
            }
        }
        private void CreateDirectoryWithPermissions(string path, string username, string domainName)
        {
            Directory.CreateDirectory(path);
            SetDirectoryPermissions(path, username, domainName, FileSystemRights.ReadAndExecute | FileSystemRights.Synchronize);

            string documentsPath = Path.Combine(path, "Belgeler");
            Directory.CreateDirectory(documentsPath);
            SetDirectoryPermissions(documentsPath, username, domainName, FileSystemRights.DeleteSubdirectoriesAndFiles | FileSystemRights.Write | FileSystemRights.ReadAndExecute | FileSystemRights.Synchronize);

            string emailPath = Path.Combine(path, "Eposta");
            Directory.CreateDirectory(emailPath);
            SetDirectoryPermissions(emailPath, username, domainName, FileSystemRights.Modify | FileSystemRights.ReadAndExecute | FileSystemRights.Synchronize);

            string groupName = "TEST\\GENEL";
            RemoveGroupAccess(path, groupName);
            RemoveGroupAccess(documentsPath, groupName);
            RemoveGroupAccess(emailPath, groupName);

            labelResult.ForeColor = System.Drawing.Color.Green;
            labelResult.Text += $"\n{documentsPath}\n{emailPath}\n{path}";
        }


        private void SetDirectoryPermissions(string path, string username, string domainName, FileSystemRights rights)
        {
            DirectorySecurity security = Directory.GetAccessControl(path);
            security.SetAccessRuleProtection(true, false);
            FileSystemAccessRule accessRule = new FileSystemAccessRule($"{domainName}\\{username}", rights, AccessControlType.Allow);
            security.AddAccessRule(accessRule);
            Directory.SetAccessControl(path, security);
        }

        private void RemoveGroupAccess(string path, string groupName)
        {
            DirectorySecurity security = Directory.GetAccessControl(path);
            AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));

            foreach (FileSystemAccessRule rule in rules)
            {
                if (rule.IdentityReference.Value.Equals(groupName, StringComparison.CurrentCultureIgnoreCase))
                {
                    security.RemoveAccessRule(rule);
                }
            }
            //null
            Directory.SetAccessControl(path, security);
        }

    }
}
