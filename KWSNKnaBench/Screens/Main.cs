using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

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
        private string boincData = null; //Boinc data location
        private string InstallLoc = null;
        private bool rVal; //Return value of the createFiles process true == created correctly, false == failed to be created

        public Main()
        {
            InitializeComponent();
        }

        public void InstantiateMyNumericUpDown()
        {
            // Create and initialize a NumericUpDown control.
            numNoCPU = new NumericUpDown();
            numPercCPU = new NumericUpDown();
            // Set the Minimum, Maximum, and initial Value.
            numNoCPU.Value = 0;
            numNoCPU.Maximum = 100;
            numNoCPU.Minimum = 0;
            numPercCPU.Value = 0;
            numPercCPU.Maximum = 100;
            numPercCPU.Minimum = 0;
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
                File.Delete(benchLoc + @"\Knabench\Suspend.cmd");
                File.Delete(benchLoc + @"\Knabench\Suspend2.cmd");
                File.Delete(benchLoc + @"\Knabench\Resume.cmd");
                File.Delete(benchLoc + @"\Knabench\Resume2.cmd");

                if (File.Exists(boincData + @"global_prefs_override_temp.xml"))
                {
                    File.Delete(boincData + @"global_prefs_override.xml");
                    System.IO.File.Copy(boincData + @"global_prefs_override_temp.xml", boincData + @"global_prefs_override.xml");
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.FileName = benchLoc + @"\Knabench\prefsOverride.cmd";
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                }
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
            txtOutput.Clear();
            benchLoc = KWSNKnaBench.Classes.Locations.location("Path");
            boincInstall = KWSNKnaBench.Classes.Locations.boinclocation("INSTALLDIR");
            boincData = KWSNKnaBench.Classes.Locations.boinclocation("DATADIR");

            if ((string.IsNullOrEmpty(benchLoc)))
            //if nothing has been passed to the var then show error
            {
                MessageBox.Show("No location for Benchmark folders found - check settings", "Select Benchmark Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //If MBBench215cmd can't be found in the supplier location then display an error
            if (!File.Exists(benchLoc + @"\Knabench\MBbench215.cmd"))
            {
                MessageBox.Show("MBBench215.cmd can not be found - check settings", "Select Benchmark Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Otherwise try to run the bench
            else
            {
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

                if (File.Exists(boincData + @"global_prefs_override.xml"))
                {
                    decimal numCPUs = numNoCPU.Value;
                    decimal percCPUs = numPercCPU.Value;
                    File.Delete(boincData + @"global_prefs_override_temp.xml");
                    System.IO.File.Copy(boincData + @"global_prefs_override.xml", boincData + @"global_prefs_override_temp.xml");
                    XmlDocument doc = new XmlDocument();
                    doc.Load(boincData + @"global_prefs_override.xml");
                    XmlNode root = doc.DocumentElement;
                    XmlNode myNode = root.SelectSingleNode("/global_preferences/cpu_usage_limit");
                    XmlNode myNode2 = root.SelectSingleNode("/global_preferences/max_ncpus_pct");
                    if (numCPUs > 0)
                    {
                        myNode.InnerText = Convert.ToString(percCPUs + ".000000");
                    }
                    if (percCPUs > 0)
                    {
                        myNode2.InnerText = Convert.ToString(numCPUs + ".000000");
                    }
                    doc.Save(boincData + @"global_prefs_override.xml");
                    rVal = KWSNKnaBench.Classes.createFiles.createCMDFiles("prefsOverride");
                    if (rVal == true)
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.FileName = benchLoc + @"\Knabench\prefsOverride.cmd";
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Override Global Prefs: " + Convert.ToString(e), "Override Prefs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                //Check for any suspend files left over from last bench and delete if they do
                File.Delete(benchLoc + @"\Knabench\Suspend.cmd");
                File.Delete(benchLoc + @"\Knabench\Suspend2.cmd");
                File.Delete(benchLoc + @"\Knabench\Resume.cmd");
                File.Delete(benchLoc + @"\Knabench\Resume2.cmd");

                //Dependant on what the user has selected suspend only CPU tasks.....
                if (rdoSuspendCPU.Checked)
                {
                    rVal = KWSNKnaBench.Classes.createFiles.createCMDFiles("SuspendCPU");

                    if (rVal == true)
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.FileName = benchLoc + @"\Knabench\Suspend.cmd";
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Suspend CPU Tasks: " + Convert.ToString(e), "Suspend Tasks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //or suspend only GPU tasks.....
                if (rdoSuspendGPU.Checked)
                {
                    rVal = KWSNKnaBench.Classes.createFiles.createCMDFiles("SuspendGPU");

                    if (rVal == true)
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.FileName = benchLoc + @"\Knabench\Suspend.cmd";
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Suspend GPU Tasks: " + Convert.ToString(e), "Suspend Tasks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //or suspend all tasks.....
                if (rdoSuspendBoinc.Checked)
                {
                    rVal = KWSNKnaBench.Classes.createFiles.createCMDFiles("SuspendAll");

                    if (rVal == true)
                    {
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
                    else
                    {
                        MessageBox.Show("Unable to Suspend All Tasks: " + Convert.ToString(e), "Suspend Tasks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            else
            {
                this.txtOutput.AppendText(text);
            }
        }

        //Sends an e-mail with the benchmark file if required
        private void btnEmail_Click(object sender, EventArgs e)
        {
            InstallLoc = KWSNKnaBench.Classes.Locations.location("Path");
            emailServer = KWSNKnaBench.Classes.Locations.location("SMTPServer");
            emailPort = KWSNKnaBench.Classes.Locations.location("SMTPPort");
            emailUser = KWSNKnaBench.Classes.Locations.location("SMTPAddress");
            string SMTPPassword = KWSNKnaBench.Classes.Locations.location("SMTPPassword");
            if (string.IsNullOrEmpty(SMTPPassword))
            {
                emailPass = "";
            }
            else
            {
                emailPass = Crypto.Decrypt(SMTPPassword, "A7A338B93D5E3EE1C58789EE68FAB");
            }
            MailMessage mail = new MailMessage();
            if (InstallLoc != null) try
                {
                    string folder = InstallLoc + @"\Knabench\Testdatas";
                    string[] benchFiles = Directory.GetFiles(folder, "*.txt");
                    foreach (var txtfile in benchFiles)
                    {
                        mail.Attachments.Add(new System.Net.Mail.Attachment(txtfile));
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
                benchLoc = KWSNKnaBench.Classes.Locations.location("Path");
                System.IO.File.Delete(benchLoc + @"\Knabench\Testdatas\GPUDetails.txt");
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
            else
            {
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
            else
            {
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