using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace KWSNKnaBench {
	public partial class SciAppUpload: Form {
		//decalre some vars
		private string sciAppsLoc = null;
		private string sciAppsRef = null;
		private string sciAppsRes = null;
		private string newSciApps = null;

		public SciAppUpload() {
			InitializeComponent();
		}
		//Select the folder with the new sci apps - will also need to contain the .dll files
		private void btnBrowse_Click(object sender, EventArgs e) {
			FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
			folderBrowserDlg.ShowNewFolderButton = true;
			DialogResult dlgResult = folderBrowserDlg.ShowDialog();
			if (dlgResult.Equals(DialogResult.OK)) {
				txtNewSciApps.Text = folderBrowserDlg.SelectedPath;
				Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
			}
		}

		private void btnUpload_Click(object sender, EventArgs e) {
			if (MessageBox.Show("This will upload new science apps. Please ensure you have selected the correct folder which contains the .exe files and all required .dll files", "Copy New Files", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK) {
				//Move the .exe files to the reference folder
				//If the user wants to use the old sci apps as reference apps
				if (chkBoxRef.Checked) try {
					RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
					key = key.OpenSubKey("Jamie", true);
					key = key.OpenSubKey("KWSNKnaBench", true);
					Object o = key.GetValue("Path");
					string InstallLoc = (o.ToString());
					InstallLoc = InstallLoc.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
					sciAppsLoc = InstallLoc + @"\Knabench\Science_apps";
					sciAppsRef = (sciAppsLoc + @"\Reference");
					string fileExtension = "*.exe";

					string[] txtFiles = Directory.GetFiles(sciAppsLoc, fileExtension);

					foreach(var item in txtFiles) {
						File.Move(item, Path.Combine(sciAppsRef, Path.GetFileName(item)));
					}

					if (chkMoveDll.Checked) try {
						sciAppsRef = (sciAppsLoc + @"\Reference");
						fileExtension = "*.dll";

						txtFiles = Directory.GetFiles(sciAppsLoc, fileExtension);

						foreach(var item in txtFiles) {
							File.Move(item, Path.Combine(sciAppsRef, Path.GetFileName(item)));
						}
					} catch (Exception b) {
						//Throw nice error if unable to from registry
						MessageBox.Show("Unable to load current Settings: {0}, please check your settings " + b.ToString(), "Unable to load Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				} catch (Exception a) {
					//Throw nice error if unable to from registry
					MessageBox.Show("Unable to load current Settings: {0}, please check your settings " + a.ToString(), "Unable to load Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else
				//Move the *.exe files to the reserve folder
				try {
					RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
					key = key.OpenSubKey("Jamie", true);
					key = key.OpenSubKey("KWSNKnaBench", true);
					Object o = key.GetValue("Path");
					string InstallLoc = (o.ToString());
					InstallLoc = InstallLoc.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
					sciAppsLoc = InstallLoc + @"\Knabench\Science_apps";
					sciAppsRes = (sciAppsLoc + @"\Reserve");
					string fileExtension2 = "*.exe";

					string[] txtFiles2 = Directory.GetFiles(sciAppsLoc, fileExtension2);

					foreach(var item in txtFiles2) {
						File.Move(item, Path.Combine(sciAppsRes, Path.GetFileName(item)));
					}
					if (chkMoveDll.Checked) try {

						sciAppsRes = (sciAppsLoc + @"\Reserve");
						fileExtension2 = "*.dll";

						txtFiles2 = Directory.GetFiles(sciAppsLoc, fileExtension2);

						foreach(var item in txtFiles2) {
							File.Move(item, Path.Combine(sciAppsRes, Path.GetFileName(item)));
						}
					} catch (Exception b) {
						//Throw nice error if unable to from registry
						MessageBox.Show("Unable to load current Settings: {0}, please check your settings " + b.ToString(), "Unable to load Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				} catch (Exception a) {
					//Throw nice error if unable to from registry
					MessageBox.Show("Unable to load current Settings: {0}, please check your settings " + a.ToString(), "Unable to load Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				//If no location specified show an error
				if (string.IsNullOrEmpty(txtNewSciApps.Text)) {
					MessageBox.Show("No location specified - Please select where the new science apps are", "Move Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				} else try {
					RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
					key = key.OpenSubKey("Jamie", true);
					key = key.OpenSubKey("KWSNKnaBench", true);
					Object o = key.GetValue("Path");
					string InstallLoc = (o.ToString());
					InstallLoc = InstallLoc.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
					sciAppsLoc = InstallLoc + @"\Knabench\Science_apps";
					//Move all .exe and .dll files from the new location to the sci apps folder in the KnaBench folder
					newSciApps = txtNewSciApps.Text;
					string fileExtension = "*.exe";

					string[] txtFiles = Directory.GetFiles(newSciApps, fileExtension);

					foreach(var item in txtFiles) {
						File.Move(item, Path.Combine(sciAppsLoc, Path.GetFileName(item)));
					}
					fileExtension = "*.dll";

					txtFiles = Directory.GetFiles(newSciApps, fileExtension);

					if (chkMoveDll.Checked)

					foreach(var item in txtFiles) {
						File.Move(item, Path.Combine(sciAppsLoc, Path.GetFileName(item)));
					}

					MessageBox.Show("New Science Apps moved successfully", "Move Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				} catch (Exception c) {
					//Throw nice error if unable to from registry
					MessageBox.Show("Unable to move new Science Apps: " + c.ToString(), "Unable to Move", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}