/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Author:      Jamie                                                                                                                                              //
// Date:        02/12/2015                                                                                                                                         //
// Description: Allows the user to upload new science apps and either archive or set as reference apps the currenct science apps                                   //            
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Microsoft.Win32;

namespace KWSNKnaBench
{
    public partial class SciAppUpload : Form
    {
        //decalre some vars
        private string sciAppsLoc = null;
        private string sciAppsRef = null;
        private string sciAppsRes = null;
        private string newSciApps = null;

        public SciAppUpload()
        {
            InitializeComponent();
        }
        //Select the folder with the new sci apps - will also need to contain the .dll files
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.ShowNewFolderButton = true;
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                txtNewSciApps.Text = folderBrowserDlg.SelectedPath;
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will upload new science apps. Please ensure you have selected the correct folder which contains the .exe files and all required .dll files", "Copy New Files", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                //Check if a settings file exists and get the install loc from there (prefered method)
                if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml")))
                    try
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml");
                        XmlNode node = doc.DocumentElement.SelectSingleNode("/Settings/Settings");
                        sciAppsLoc = node.Attributes["Location"].InnerText + @"\Knabench\Science_apps";
                    }
                    catch (Exception a)
                    {
                        //Throw nice error if unable to load file
                        MessageBox.Show("Unable to load current Settings: {0} , please check your settings" + a.ToString(), "Unable to load Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                    try
                    {
                        //If a settings file doesn't exist then tryu to get from the registry
                        //Work out if its a 64 or 32 bit os and get the install location from the correct key
                        if (Environment.Is64BitOperatingSystem)
                        {
                            //64bit OS
                            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Jamie\\KWSNKnaBench");
                            if (key != null)
                            {
                                Object o = key.GetValue("Path");
                                if (o != null)
                                {
                                    string InstallLoc = (o.ToString());
                                    InstallLoc = InstallLoc.Remove(InstallLoc.Length - 1);
                                    sciAppsLoc = InstallLoc + @"\Knabench\Science_apps";

                                }
                            }
                        }
                        else
                        {
                            //32bit OS
                            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Jamie\\KWSNKnaBench");
                            if (key != null)
                            {
                                Object o = key.GetValue("Path");
                                if (o != null)
                                {
                                    string InstallLoc = (o.ToString());
                                    InstallLoc = InstallLoc.Remove(InstallLoc.Length - 1);
                                    sciAppsLoc = InstallLoc + @"\Knabench\Science_apps";

                                }
                            }
                        }
                    }
                    catch (Exception a)
                    {
                        //Throw nice error if unable to from registry
                        MessageBox.Show("Unable to load current Settings: {0}, please check your settings " + a.ToString(), "Unable to load Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                //Move the .exe files to the reference folder
                //If the user wants to use the old sci apps as reference apps
                if (chkBoxRef.Checked)
                {
                    sciAppsRef = (sciAppsLoc + @"\Reference");
                    string fileExtension = "*.exe";

                    string[] txtFiles = Directory.GetFiles(sciAppsLoc, fileExtension);

                    foreach (var item in txtFiles)
                    {
                        File.Move(item, Path.Combine(sciAppsRef, Path.GetFileName(item)));
                    }

                    sciAppsRef = (sciAppsLoc + @"\Reference");
                    fileExtension = "*.dll";

                    txtFiles = Directory.GetFiles(sciAppsLoc, fileExtension);

                    foreach (var item in txtFiles)
                    {
                        File.Move(item, Path.Combine(sciAppsRef, Path.GetFileName(item)));
                    }

                }
                else
                //Move the *.exe files to the reserve folder
                {
                    sciAppsRes = (sciAppsLoc + @"\Reserve");
                    string fileExtension = "*.exe";

                    string[] txtFiles = Directory.GetFiles(sciAppsLoc, fileExtension);

                    foreach (var item in txtFiles)
                    {
                        File.Move(item, Path.Combine(sciAppsRes, Path.GetFileName(item)));
                    }
                    sciAppsRes = (sciAppsLoc + @"\Reserve");
                    fileExtension = "*.dll";

                    txtFiles = Directory.GetFiles(sciAppsLoc, fileExtension);

                    foreach (var item in txtFiles)
                    {
                        File.Move(item, Path.Combine(sciAppsRes, Path.GetFileName(item)));
                    }

                }
                //If no location specified show an error
                if (string.IsNullOrEmpty(txtNewSciApps.Text))
                    {
                    MessageBox.Show("No location specified - Please select where the new science apps are", "Move Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                else
                    try
                    {
                        //Move all .exe and .dll files from the new location to the sci apps folder in the KnaBench folder
                        newSciApps = txtNewSciApps.Text;
                        string fileExtension = "*.exe";

                        string[] txtFiles = Directory.GetFiles(newSciApps, fileExtension);

                        foreach (var item in txtFiles)
                        {
                            File.Move(item, Path.Combine(sciAppsLoc, Path.GetFileName(item)));
                        }
                        fileExtension = "*.dll";

                        txtFiles = Directory.GetFiles(newSciApps, fileExtension);

                        foreach (var item in txtFiles)
                        {
                            File.Move(item, Path.Combine(sciAppsLoc, Path.GetFileName(item)));
                        }

                        MessageBox.Show("New Science Apps moved successfully", "Move Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception c)
                    {
                        //Throw nice error if unable to from registry
                        MessageBox.Show("Unable to move new Science Apps: " + c.ToString(), "Unable to Move", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
    }
}