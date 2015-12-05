/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Author:      Jamie                                                                                                                                              //
// Date:        02/12/2015                                                                                                                                         //
// Description: Main screen of the app - allows user to open other screens\run the benchmark and email out the benchmark file                                      //            
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace KWSNKnaBench
{
    public partial class Main : Form
    {
        //Declare some vars
        private string benchLoc = null;     //Location of the KnaBench folder
        private string emailServer = null;  //SMTP E-mail address (i.e. smtp.live.com = Hotmail)
        private string emailPort = null;    //Port the above server uses
        private string emailUser = null;    //E-mail address of user
        private string emailPass = null;    //Users e-mail password

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
            //Get the location of the bench folder from the xml settings file
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml")))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml");
                XmlNode node = doc.DocumentElement.SelectSingleNode("/Settings/Settings");
                benchLoc = node.Attributes["Location"].InnerText;
            }
            else
            {
                MessageBox.Show("Cannot find Settings file. Ensure you have entered your settings", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                try
                {
                    //Start the benchmark and redirect the output from the mbbench.cmd from a console window to the app hiding the console
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WorkingDirectory = benchLoc + @"\Knabench";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.FileName = benchLoc + @"\Knabench\MBbench214.cmd";
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
            else
            {
                this.txtOutput.AppendText("Failed." + Environment.NewLine);
            }

            proc.Close();
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
            //Check the settings file exists and if so load the details
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml")))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml");
                XmlNode node = doc.DocumentElement.SelectSingleNode("/Settings/Settings");
                emailServer = node.Attributes["EmailServer"].InnerText;
                emailPort = node.Attributes["EmailPort"].InnerText;
                emailUser = node.Attributes["EmailUser"].InnerText;
                emailPass = Crypto.Decrypt(node.Attributes["EmailPassword"].InnerText, "A7A338B93D5E3EE1C58789EE68FAB");
                benchLoc = node.Attributes["Location"].InnerText;
            }
            else
            //Otherwise show an error
            {
                MessageBox.Show("E-mail details are missing - please check your settings", "No E-mail Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if settings file is missing some e-mail details show a message and stop
            if ((string.IsNullOrEmpty(emailServer)) || (string.IsNullOrEmpty(emailServer)) || (string.IsNullOrEmpty(emailUser)) || (string.IsNullOrEmpty(emailPass)))
            {
                MessageBox.Show("E-mail details are missing - please check your settings", "No E-mail Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                try
                {
                    //Try to attach the document and send the e-mail atrtaching the file
                    XmlDocument doc = new XmlDocument();
                    doc.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KWSNKnaBench_Settings\Settings.xml");
                    XmlNode node = doc.DocumentElement.SelectSingleNode("/Settings/Settings");
                    string folder = node.Attributes["Location"].InnerText + @"\Knabench\Testdatas";
                    string[] benchFiles = Directory.GetFiles(folder, "*.txt");
                    int ConvertEmailPort = 0;
                    Int32.TryParse(emailPort, out ConvertEmailPort);
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient(emailServer);
                    mail.From = new MailAddress(emailUser);
                    mail.To.Add("jtiller@hotmail.co.uk");
                    mail.Subject = "New Benchmark File";
                    mail.Body = "New Benchmark File";
                    //Loop through each file and attach all text files to the email - ToDo limit this to the benchmark file only rather than all .txt files
                    foreach (var txtfile in benchFiles)
                    {
                        mail.Attachments.Add(new System.Net.Mail.Attachment(txtfile));
                    }
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}