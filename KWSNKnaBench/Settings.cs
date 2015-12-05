/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Author:      Jamie                                                                                                                                              //
// Date:        02/12/2015                                                                                                                                         //
// Description: Allows the user to set various settings for the apps to work these include:                                                                        //  
//                  1. The location of the KnaBench folder (if not useing the supplied folder)                                                                     //
//                  2. The smtp settings of their e-mail provider - opnly SMTP email supported for now                                                             //                            
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Microsoft.Win32;

namespace KWSNKnaBench
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Load += Settings_Shown;
        }


        //Auto click the refresh button to load the data from xml into the form
        private void Settings_Shown(Object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }
        //Button to load the location of the Benchmark folder
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
        //Button to save the settings to an xml file in the %appdata% folder for the logged in user
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Check to see if an settings folder exists in %appdata% folder if not create it
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings");
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            //Throw an error if not able to create the settings folder
            catch (Exception d)
            {
                MessageBox.Show("Unable to create Settings Folder: {0} " + d.ToString(), "Unable to Settings Archive Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Check to see if the settings file already exists
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml")))
                try
                {
                    //If it does delete it (easier than editing the existing one :)
                    File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml"));
                }
                catch (Exception c)
                {
                    //Throw nice error isf unable to delete the file
                    MessageBox.Show("Unable to refresh Settings File: {0} " + c.ToString(), "Unable to Settings File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            //Create the xml file and populate with values from the form
            try
            {
                XDocument Xdoc = new XDocument(new XElement("Settings"));
                Xdoc = new XDocument();

                Crypto.Encrypt(txtEmailPass.Text, "A7A338B93D5E3EE1C58789EE68FAB");

                XElement xml = new XElement("Settings",
                new XElement("Settings",
                new XAttribute("Location", txtBenchLoc.Text),
                new XAttribute("EmailServer", txtSMTPServer.Text),
                new XAttribute("EmailPort", txtSMTPPort.Text),
                new XAttribute("EmailUser", txtEmailUser.Text),
                new XAttribute("EmailPassword", Crypto.Encrypt(txtEmailPass.Text, "A7A338B93D5E3EE1C58789EE68FAB"))));

                if (Xdoc.Descendants().Count() > 0) Xdoc.Descendants().First().Add(xml);
                else {
                    Xdoc.Add(xml);
                }

                Xdoc.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml"));
                this.Close();
            }
            catch (Exception b)
            {
                //Throw nice error isf unable to delete the file
                MessageBox.Show("Unable to save Settings: {0} " + b.ToString(), "Unable to Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button to load the current settings from the file
        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml")))
                try
                {
                    //Crypto.Encrypt(txtEmailPass.Text, "A7A338B93D5E3EE1C58789EE68FAB")
                    XmlDocument doc = new XmlDocument();
                    doc.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml");
                    XmlNode node = doc.DocumentElement.SelectSingleNode("/Settings/Settings");
                    txtBenchLoc.Text = node.Attributes["Location"].InnerText;
                    txtSMTPServer.Text = node.Attributes["EmailServer"].InnerText;
                    txtSMTPPort.Text = node.Attributes["EmailPort"].InnerText;
                    txtEmailUser.Text = node.Attributes["EmailUser"].InnerText;
                    txtEmailPass.Text = Crypto.Decrypt(node.Attributes["EmailPassword"].InnerText, "A7A338B93D5E3EE1C58789EE68FAB");
                }
                catch (Exception a)
                {
                    //Throw nice error if unable to load file
                    MessageBox.Show("Unable to load current Settings: {0} " + a.ToString(), "Unable to load Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else try
                {
                    //Work out if its a 64 or 32 bit os and get the install location from the correct key
                    if (Environment.Is64BitOperatingSystem)
                    {
                        RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Jamie\\KWSNKnaBench");
                        if (key != null)
                        {
                            Object o = key.GetValue("Path");
                            if (o != null)
                            {
                                string InstallLoc = (o.ToString());
                                InstallLoc = InstallLoc.Remove(InstallLoc.Length - 1);
                                txtBenchLoc.Text = InstallLoc;

                            }
                        }
                    }
                    else {
                        RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Jamie\\KWSNKnaBench");
                        if (key != null)
                        {
                            Object o = key.GetValue("Path");
                            if (o != null)
                            {
                                string InstallLoc = (o.ToString());
                                InstallLoc = InstallLoc.Remove(InstallLoc.Length - 1);
                                txtBenchLoc.Text = InstallLoc;

                            }
                        }
                    }

                    XDocument Xdoc = new XDocument(new XElement("Settings"));
                    Xdoc = new XDocument();
                    XElement xml = new XElement("Settings",
                    new XElement("Settings",
                    new XAttribute("Location", txtBenchLoc.Text),
                    new XAttribute("EmailServer", txtSMTPServer.Text),
                    new XAttribute("EmailPort", txtSMTPPort.Text),
                    new XAttribute("EmailUser", txtEmailUser.Text),
                    new XAttribute("EmailPassword", Crypto.Encrypt(txtEmailPass.Text, "A7A338B93D5E3EE1C58789EE68FAB"))));

                    if (Xdoc.Descendants().Count() > 0) Xdoc.Descendants().First().Add(xml);
                    else {
                        Xdoc.Add(xml);
                    }

                    Xdoc.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml"));
                    //this.Close();
                }
                catch (Exception b)
                {
                    //Throw nice error if unable to load file
                    MessageBox.Show("Unable to load current Settings: {0} " + b.ToString(), "Unable to load Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        //Clear out the settings and delete the settings file
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBenchLoc.Text = "";
            txtEmailPass.Text = "";
            txtEmailUser.Text = "";
            txtSMTPPort.Text = "";
            txtSMTPServer.Text = "";
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml")))
                try
                {
                    //If it does delete it (easier than editing the existing one :)
                    File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml"));
                }
                catch (Exception c)
                {
                    //Throw nice error isf unable to delete the file
                    MessageBox.Show("Unable to clear Settings: {0} " + c.ToString(), "Unable to Settings File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        //Hide or show the users e-mail password based on check box
        private void chkBoxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShowPwd.Checked)
            {
                txtEmailPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtEmailPass.UseSystemPasswordChar = true;
            }
        }
    }
}