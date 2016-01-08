using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace KWSNKnaBench
{
    public partial class Main : Form
    {
        //Declare some vars
        private string benchLoc = null; //Location of the KnaBench folder
        private string emailServer = null; //SMTP E-mail address (i.e. smtp.live.com = Hotmail)
        private string emailPort = null; //Port the above server uses
        private string emailUser = null; //E-mail address of user
        private string emailPass = null; //Users e-mail password
        private string boincInstall = null; //Boinc install location
        private bool boincSuspend = true; //Flag set if the bench app has suspended boinc

        public Main()
        {
            InitializeComponent();
        }
        //Launch Settings form
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings Check = new Settings();
            Check.Show();

        }
        //Launch Upload Sci Apps form
        private void uploadNewAppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SciAppUpload Check = new SciAppUpload();
            Check.Show();
        }
        //Quit the application if OK is selected on button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Quit KnaBench", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        //Load the about form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About Check = new About();
            Check.Show();
        }
        //Show the help file
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"./Resources/help.chm");
        }



        //Launch the benchmark 
        private void btnRunBench_Click(object sender, EventArgs e)
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
                    benchLoc = InstallLoc;

                }
            }
            //Get the install location of Boinc for some reason Bopinc always writes to the 32bit Software key even on 64bit machines and installs.....
            RegistryKey key2 = Registry.LocalMachine.OpenSubKey("Software", true);
            key2 = key2.OpenSubKey("Space Sciences Laboratory, U.C. Berkeley", true);
            key2 = key2.OpenSubKey("BOINC Setup", true);
            if (key2 != null)
            {
                object p = key2.GetValue("INSTALLDIR");
                if ( p != null)
                {
                    boincInstall = (p.ToString());
                }
            }

            if ((string.IsNullOrEmpty(benchLoc)))
            //if nothing has been passed to the var then show error
            {
                MessageBox.Show("No location for Benchmark folders found - check settings", "Select Benchmark Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //If MBBench214cmd can't be found in the supplier location then display an error
            if (!File.Exists(benchLoc + @"\Knabench\MBbench214.cmd"))
            {
                MessageBox.Show("MBBench214.cmd can not be found - check settings", "Select Benchmark Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Otherwise try to run the bench
            else {
                try
                {
                    //Check to see if an Archive folder exists in Testdatas folder if not create it
                    string path = benchLoc + @"\Knabench\Testdatas\Archive";
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }
                catch (Exception d)
                {
                    MessageBox.Show("Unable to create Archive Folder: {0} " + d.ToString(), "Unable to Create Archive Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Move any old *-benchMB files to an archive location
                string pattern = @"(\-benchMB.txt)";
                var files = Directory.GetFiles(benchLoc + @"\Knabench\Testdatas").Where(x => Regex.IsMatch(x, pattern)).Select(x => x).ToList();
                foreach (var item in files)
                    try
                    {
                        {
                            Console.WriteLine(item);
                            string name = item.Substring(item.LastIndexOf("\\") + 1);
                            File.Move(item, Path.Combine(benchLoc + @"\Knabench\Testdatas\Archive", name));
                        }
                    }
                    //Show error if move failed
                    catch (Exception c)
                    {
                        MessageBox.Show("Unable to move old benchmark files: {0} " + c.ToString(), "Unable to Move Archive Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                //Check for any suspend files left over from last bench and delete if they do
                if (File.Exists(benchLoc + @"\Knabench\Suspend.cmd"))
                {
                    File.Delete(benchLoc + @"\Knabench\Suspend.cmd");
                }
                if (File.Exists(benchLoc + @"\Knabench\Suspend2.cmd"))
                {
                    File.Delete(benchLoc + @"\Knabench\Suspend2.cmd");
                }
                if (File.Exists(benchLoc + @"\Knabench\Resume.cmd"))
                {
                    File.Delete(benchLoc + @"\Knabench\Resume.cmd");
                }
                if (File.Exists(benchLoc + @"\Knabench\Resume2.cmd"))
                {
                    File.Delete(benchLoc + @"\Knabench\Resume2.cmd");
                }
                //Dependant on what the user has selected suspend only CPU tasks.....
                if (rdoSuspendCPU.Checked)
                {
                    boincSuspend = true;
                    System.IO.File.WriteAllText(benchLoc + @"\Knabench\Suspend.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_run_mode never 172800");
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.FileName = benchLoc + @"\Knabench\Suspend.cmd";
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                }
                //or suspend only GPU tasks.....
                if (rdoSuspendGPU.Checked)
                {
                    boincSuspend = true;
                    System.IO.File.WriteAllText(benchLoc + @"\Knabench\Suspend.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_gpu_mode never 172800");
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.FileName = benchLoc + @"\Knabench\Suspend.cmd";
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                }
                //or suspend all tasks.....
                if (rdoSuspendBoinc.Checked)
                {
                    boincSuspend = true;
                    System.IO.File.WriteAllText(benchLoc + @"\Knabench\Suspend.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_gpu_mode never 172800");
                    System.IO.File.WriteAllText(benchLoc + @"\Knabench\Suspend2.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_run_mode never 172800");
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.FileName = benchLoc + @"\Knabench\Suspend.cmd";
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    System.Diagnostics.Process process2 = new System.Diagnostics.Process();
                    process2.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                    process2.StartInfo.UseShellExecute = false;
                    process2.StartInfo.FileName = benchLoc + @"\Knabench\Suspend2.cmd";
                    process2.StartInfo.CreateNoWindow = true;
                    process2.Start();
                }

                try
                {
                    //Start the benchmark and redirect the output from the mbbench.cmd from a console window to the app hiding the console
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.FileName = benchLoc + @"\Knabench\MBbench215.cmd";
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.ErrorDataReceived += proc_DataReceived;
                    process.OutputDataReceived += proc_DataReceived;
                    process.Exited += new EventHandler(ProcExited);
                    process.StartInfo.Verb = "runas";
                    process.Start();
                    process.BeginErrorReadLine();
                    process.BeginOutputReadLine();
                }
                //If something goes wrong show an error message
                catch (Exception b)
                {
                    MessageBox.Show("Unable to run Benchmark: {0} " + b.ToString(), "Error Running Bench", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProcExited(object sender, System.EventArgs e)
        {
            Process proc = (Process)sender;

            // Wait a short while to allow all console output to be processed and appended
            // before appending the success/fail message.
            Thread.Sleep(40);

            if (proc.ExitCode == 0)
            {
                this.txtOutput.AppendText("Success." + Environment.NewLine);
            }
            else {
                this.txtOutput.AppendText("Failed." + Environment.NewLine);
            }

            proc.Close();

            if (boincSuspend == true)
            {
                System.IO.File.WriteAllText(benchLoc + @"\Knabench\Resume.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_gpu_mode never 1");
                System.IO.File.WriteAllText(benchLoc + @"\Knabench\Resume2.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_run_mode never 1");
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = benchLoc + @"\Knabench\Resume.cmd";
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                System.Diagnostics.Process process2 = new System.Diagnostics.Process();
                process2.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                process2.StartInfo.UseShellExecute = false;
                process2.StartInfo.FileName = benchLoc + @"\Knabench\Resume2.cmd";
                process2.StartInfo.CreateNoWindow = true;
                process2.Start();
            }
        }
        //Write the line to the output window line by line
        void proc_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.AppendText(e.Data + Environment.NewLine);
            }
        }

        delegate void AppendTextDelegate(string text);

        //Call a threadsafe method of updating the text box with the output of the bench
        private void AppendText(string text)
        {
            if (this.txtOutput.InvokeRequired)
            {
                txtOutput.Invoke(new AppendTextDelegate(this.AppendText), new object[] {
                    text
                });
            }
            else {
                this.txtOutput.AppendText(text);
            }
        }

        //Sends an e-mail with the benchmark file if required
        private void btnEmail_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key = key.OpenSubKey("Jamie", true);
            key = key.OpenSubKey("KWSNKnaBench", true);
            if (key != null) try
                {
                    Object o = key.GetValue("Path");
                    string InstallLoc = (o.ToString());
                    InstallLoc = InstallLoc.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
                    string folder = InstallLoc + @"\Knabench\Testdatas";
                    string[] benchFiles = Directory.GetFiles(folder, "*.txt");
                    //Loop through each file and attach all text files to the email - ToDo limit this to the benchmark file only rather than all .txt files
                    foreach (var txtfile in benchFiles)
                    {
                        mail.Attachments.Add(new System.Net.Mail.Attachment(txtfile));
                    }
                    Object p = key.GetValue("SMTPServer");
                    string SMTPServer = (p.ToString());
                    emailServer = SMTPServer;
                    Object q = key.GetValue("SMTPPort");
                    string SMTPPort = (q.ToString());
                    emailPort = SMTPPort;
                    Object r = key.GetValue("SMTPAddress");
                    string SMTPAddress = (r.ToString());
                    emailUser = SMTPAddress;
                    Object s = key.GetValue("SMTPPassword");
                    string SMTPPassword = (s.ToString());
                    if (string.IsNullOrEmpty(SMTPPassword))
                    {
                        emailPass = "";
                    }
                    else {
                        emailPass = Crypto.Decrypt(SMTPPassword, "A7A338B93D5E3EE1C58789EE68FAB");
                    }
                    int ConvertEmailPort = 0;
                    Int32.TryParse(emailPort, out ConvertEmailPort);
                    mail.From = new MailAddress(emailUser);
                    mail.To.Add("jtiller@hotmail.co.uk");
                    mail.Subject = "New Benchmark File";
                    mail.Body = "New Benchmark File";
                    SmtpClient SmtpServer = new SmtpClient(emailServer);
                    SmtpServer.Port = (ConvertEmailPort);
                    SmtpServer.Credentials = new System.Net.NetworkCredential(emailUser, emailPass);
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    //If successful show a message
                    MessageBox.Show("Thank you, the benchmark file has been sent", "Benchmark Sent", MessageBoxButtons.OK);
                }
                //Catch the error and show a message if the email fails to send
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to send benchmark file: " + ex.ToString(), "E-mail Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnGPUDetails_Click(object sender, EventArgs e)
        {
            try
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
                        benchLoc = InstallLoc;

                    }
                }
                //Write some details to the GPU Details tab
                if (File.Exists(@"\Knabench\Testdatas\GPUDetails.txt"))
                {
                    System.IO.File.Delete(@"\Knabench\Testdatas\GPUDetails.txt");
                }
                txtGpuDetails.Clear();

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WorkingDirectory = benchLoc;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = benchLoc + @"\deviceQueryDrv.exe";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.ErrorDataReceived += proc_DataReceived2;
                process.OutputDataReceived += proc_DataReceived2;
                process.Exited += new EventHandler(ProcExited2);
                process.StartInfo.Verb = "runas";
                process.Start();
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
            }
            //If something goes wrong show an error message
            catch (Exception b)
            {
                MessageBox.Show("Unable to get GPU Details: {0} " + b.ToString(), "Error Getting Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      private void ProcExited2(object sender, System.EventArgs e)
        {
            Process proc = (Process)sender;

            // Wait a short while to allow all console output to be processed and appended
            // before appending the success/fail message.
            Thread.Sleep(40);

            if (proc.ExitCode == 0)
            {
                this.txtGpuDetails.AppendText("Success." + Environment.NewLine);
            }
            else {
                this.txtGpuDetails.AppendText("Failed." + Environment.NewLine);
            }

            proc.Close();
        }
        //Write the line to the output window line by line
        void proc_DataReceived2(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.AppendText2(e.Data + Environment.NewLine);
            }
        }
        delegate void AppendTextDelegate2(string text);

        //Call a threadsafe method of updating the text box with the output of the bench
        private void AppendText2(string text)
        {
            if (this.txtGpuDetails.InvokeRequired)
            {
                txtGpuDetails.Invoke(new AppendTextDelegate2(this.AppendText2), new object[] {
                    text
                });
            }
            else {
                this.txtGpuDetails.AppendText(text);
                using (StreamWriter sw2 = new StreamWriter(benchLoc + @"\Knabench\Testdatas\GPUDetails.txt"))
                {
                    sw2.WriteLine(txtGpuDetails.Text);
                    sw2.Close();
                }
            }
        }
    }
}