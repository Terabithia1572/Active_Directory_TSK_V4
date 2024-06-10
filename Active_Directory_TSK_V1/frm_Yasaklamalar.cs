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
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace Active_Directory_TSK_V1
{
    public partial class frm_Yasaklamalar : MetroFramework.Forms.MetroForm
    {
        public frm_Yasaklamalar()
        {
            InitializeComponent();
            LoadServerList();
            LoadOUList(comboServer.SelectedItem.ToString());

        }
        private void LoadServerList()
        {
            try
            {
                comboServer.Items.Clear();
                foreach (DomainController dc in Domain.GetCurrentDomain().DomainControllers)
                {
                    comboServer.Items.Add(dc.Name);
                }

                if (comboServer.Items.Count > 0)
                {
                    comboServer.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No domain controllers found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading domain controllers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadOUList(string server)
        {
            comboOU.Items.Clear();
            try
            {
                DirectoryEntry rootDSE = new DirectoryEntry($"LDAP://{server}/RootDSE");
                string defaultNamingContext = rootDSE.Properties["defaultNamingContext"][0].ToString();
                DirectoryEntry entry = new DirectoryEntry($"LDAP://{server}/{defaultNamingContext}");
                DirectorySearcher searcher = new DirectorySearcher(entry)
                {
                    Filter = "(objectClass=organizationalUnit)"
                };

                foreach (SearchResult result in searcher.FindAll())
                {
                    string ouName = result.Properties["ou"][0].ToString();
                    comboOU.Items.Add($"OU={ouName},{defaultNamingContext}");
                }

                if (comboOU.Items.Count > 0)
                {
                    comboOU.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No OUs found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading OUs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnApplyGPO_Click(object sender, EventArgs e)
        {
            string selectedServer = comboServer.SelectedItem.ToString();
            string selectedOU = comboOU.SelectedItem.ToString();
            string gpoName = txtGPOName.Text.Trim();

            if (string.IsNullOrEmpty(gpoName))
            {
                MessageBox.Show("Lütfen GPO Adını Boş Bırakmayınız..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (PowerShell ps = PowerShell.Create())
            {
                ps.AddScript($"New-GPO -Name '{gpoName}' -Server '{selectedServer}'");
                ps.AddScript($"New-GPLink -Name '{gpoName}' -Target '{selectedOU}'");

                if (chkDisableCMD.Checked)
                {
                    ps.AddScript($"Set-GPRegistryValue -Name '{gpoName}' -Key 'HKCU\\Software\\Policies\\Microsoft\\Windows\\System' -ValueName 'DisableCMD' -Type DWord -Value 1 -Server '{selectedServer}'");
                }

                if (chkDisablePowerShell.Checked)
                {
                    ps.AddScript($"Set-GPRegistryValue -Name '{gpoName}' -Key 'HKCU\\Software\\Policies\\Microsoft\\Windows\\System' -ValueName 'EnableScripts' -Type DWord -Value 0 -Server '{selectedServer}'");
                }

                if (chkDisableNetworkSettings.Checked)
                {
                    ps.AddScript($"Set-GPRegistryValue -Name '{gpoName}' -Key 'HKCU\\Software\\Policies\\Microsoft\\Windows\\Network Connections' -ValueName 'NC_AllowNetBridge_NLA' -Type DWord -Value 0 -Server '{selectedServer}'");
                }

                if (chkHideCDrive.Checked)
                {
                    ps.AddScript($"Set-GPRegistryValue -Name '{gpoName}' -Key 'HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer' -ValueName 'NoDrives' -Type DWord -Value 4 -Server '{selectedServer}'");
                }

                if (chkDisableAccessCDrive.Checked)
                {
                    ps.AddScript($"Set-GPRegistryValue -Name '{gpoName}' -Key 'HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer' -ValueName 'NoViewOnDrive' -Type DWord -Value 4 -Server '{selectedServer}'");
                }

                ps.Invoke();

                if (ps.Streams.Error.Count > 0)
                {
                    string errors = string.Join(Environment.NewLine, ps.Streams.Error);
                    MessageBox.Show($"Error: {errors}", "GPO Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("GPO Başarıyla Uygulandı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frm_Yasaklamalar_Load(object sender, EventArgs e)
        {
           
        }

        private void comboServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedServer = comboServer.SelectedItem.ToString();
            LoadOUList(selectedServer);
        }
    }
}
