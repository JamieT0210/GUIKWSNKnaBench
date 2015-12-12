/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Author:      Jamie                                                                                                                                              //
// Date:        02/12/2015                                                                                                                                         //
// Description: Allows the user to set various settings for the apps to work these include:                                                                        //  
//                  1. The location of the KnaBench folder (if not useing the supplied folder)                                                                     //
//                  2. The smtp settings of their e-mail provider - only SMTP email supported for now                                                              //
//                  3. All setttings now stored to the registry and added encryption of password 05/12/15                                                          //                                                                                  
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace KWSNKnaBench
{
    public partial class Settings : Form
    {

        public Settings()
        {
            InitializeComponent();
            //Auto click the refresh button
            Load += Settings_Shown;
        }

        private void Settings_Shown(Object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        //Allow the user to select a folder location of the KWSNKnaBench files
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            {
                FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
                folderBrowserDlg.ShowNewFolderButton = true;
                DialogResult dlgResult = folderBrowserDlg.ShowDialog();
                if (dlgResult.Equals(DialogResult.OK))
                {
                    txtBenchLoc.Text = folderBrowserDlg.SelectedPath;
                    Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
                }
            }
        }

        //Hide or show the password value
        private void chkBoxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShowPwd.Checked)
            {
                txtEmailPass.UseSystemPasswordChar = false;
            }
            else {
                txtEmailPass.UseSystemPasswordChar = true;
            }
        }
        //Save any new settings
        private void btnSave_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key = key.OpenSubKey("Jamie", true);
            key = key.OpenSubKey("KWSNKnaBench", true);
            if (key != null)
            {
                key.SetValue("Path", txtBenchLoc.Text);
                key.SetValue("SMTPServer", txtSMTPServer.Text);
                key.SetValue("SMTPPort", txtSMTPPort.Text);
                key.SetValue("SMTPAddress", txtEmailUser.Text);
                if (string.IsNullOrEmpty(txtEmailPass.Text))
                {
                    key.SetValue("SMTPPassword", "");
                }
                else {
                    key.SetValue("SMTPPassword", Crypto.Encrypt(txtEmailPass.Text, "A7A338B93D5E3EE1C58789EE68FAB"));
                }
            }
            if (MessageBox.Show("New Settings Have Been Saved", "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
            }
        }
        //Clear out any settings
        private void btnClear_Click(object sender, EventArgs e)
        {

            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key = key.OpenSubKey("Jamie", true);
            key = key.OpenSubKey("KWSNKnaBench", true);
            if (key != null)
            {
                key.SetValue("Path", "");
                key.SetValue("SMTPServer", "");
                key.SetValue("SMTPPort", "");
                key.SetValue("SMTPAddress", "");
                key.SetValue("SMTPPassword", "");
                btnRefresh.PerformClick(); //Refresh the screen
            }
            MessageBox.Show("Settings Have Been Cleared - Please enter New Settings Before Running Your Next Benchmark", "Settings Cleared", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key = key.OpenSubKey("Jamie", true);
            key = key.OpenSubKey("KWSNKnaBench", true);
            if (key != null)
            {
                Object o = key.GetValue("Path");
                if (o != null)
                {
                    string InstallLoc = (o.ToString());
                    InstallLoc = InstallLoc.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
                    txtBenchLoc.Text = InstallLoc;

                }
                Object p = key.GetValue("SMTPServer");
                if (p != null)
                {
                    string SMTPServer = (p.ToString());
                    txtSMTPServer.Text = SMTPServer;

                }
                Object q = key.GetValue("SMTPPort");
                if (q != null)
                {
                    string SMTPPort = (q.ToString());
                    txtSMTPPort.Text = SMTPPort;

                }
                Object r = key.GetValue("SMTPAddress");
                if (r != null)
                {
                    string SMTPAddress = (r.ToString());
                    txtEmailUser.Text = SMTPAddress;

                }
                Object s = key.GetValue("SMTPPassword");
                if (s != null)
                {
                    string SMTPPassword = (s.ToString());
                    if (string.IsNullOrEmpty(SMTPPassword))
                    {
                        txtEmailPass.Text = "";
                    }
                    else {
                        txtEmailPass.Text = Crypto.Decrypt(SMTPPassword, "A7A338B93D5E3EE1C58789EE68FAB");
                    }
                }
            }
        }
    }
}