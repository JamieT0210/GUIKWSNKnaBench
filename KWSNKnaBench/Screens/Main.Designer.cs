﻿namespace KWSNKnaBench
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadNewAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnRunBench = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabOutput = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtGpuDetails = new System.Windows.Forms.TextBox();
            this.btnGPUDetails = new System.Windows.Forms.Button();
            this.picSeti = new System.Windows.Forms.PictureBox();
            this.rdoSuspendBoinc = new System.Windows.Forms.RadioButton();
            this.rdoSuspendCPU = new System.Windows.Forms.RadioButton();
            this.rdoSuspendGPU = new System.Windows.Forms.RadioButton();
            this.numNoCPU = new System.Windows.Forms.NumericUpDown();
            this.lblNumCPUs = new System.Windows.Forms.Label();
            this.lblPercCPU = new System.Windows.Forms.Label();
            this.numPercCPU = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.tabOutput.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.uploadNewAppsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // uploadNewAppsToolStripMenuItem
            // 
            this.uploadNewAppsToolStripMenuItem.Name = "uploadNewAppsToolStripMenuItem";
            this.uploadNewAppsToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.uploadNewAppsToolStripMenuItem.Text = "Upload New Apps";
            this.uploadNewAppsToolStripMenuItem.Click += new System.EventHandler(this.uploadNewAppsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(6, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(858, 320);
            this.txtOutput.TabIndex = 1;
            // 
            // btnRunBench
            // 
            this.btnRunBench.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunBench.Location = new System.Drawing.Point(250, 260);
            this.btnRunBench.Name = "btnRunBench";
            this.btnRunBench.Size = new System.Drawing.Size(130, 84);
            this.btnRunBench.TabIndex = 3;
            this.btnRunBench.Text = "Run Benchmark";
            this.btnRunBench.UseVisualStyleBackColor = true;
            this.btnRunBench.Click += new System.EventHandler(this.btnRunBench_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.Location = new System.Drawing.Point(386, 260);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(130, 84);
            this.btnEmail.TabIndex = 4;
            this.btnEmail.Text = "E-mail Benchmark";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "D:\\Jamie\\Documents\\HelpNDoc\\Output\\Build chm documentation\\Help.chm";
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.tabPage1);
            this.tabOutput.Controls.Add(this.tabPage2);
            this.tabOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOutput.Location = new System.Drawing.Point(13, 350);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.SelectedIndex = 0;
            this.tabOutput.Size = new System.Drawing.Size(878, 359);
            this.tabOutput.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtOutput);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Benchmark Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtGpuDetails);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GPU Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtGpuDetails
            // 
            this.txtGpuDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGpuDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGpuDetails.Location = new System.Drawing.Point(7, 4);
            this.txtGpuDetails.Multiline = true;
            this.txtGpuDetails.Name = "txtGpuDetails";
            this.txtGpuDetails.ReadOnly = true;
            this.txtGpuDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGpuDetails.Size = new System.Drawing.Size(857, 316);
            this.txtGpuDetails.TabIndex = 0;
            // 
            // btnGPUDetails
            // 
            this.btnGPUDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGPUDetails.Location = new System.Drawing.Point(522, 260);
            this.btnGPUDetails.Name = "btnGPUDetails";
            this.btnGPUDetails.Size = new System.Drawing.Size(130, 84);
            this.btnGPUDetails.TabIndex = 6;
            this.btnGPUDetails.Text = "Write GPU Details";
            this.btnGPUDetails.UseVisualStyleBackColor = true;
            this.btnGPUDetails.Click += new System.EventHandler(this.btnGPUDetails_Click);
            // 
            // picSeti
            // 
            this.picSeti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSeti.Image = ((System.Drawing.Image)(resources.GetObject("picSeti.Image")));
            this.picSeti.Location = new System.Drawing.Point(292, 51);
            this.picSeti.Name = "picSeti";
            this.picSeti.Size = new System.Drawing.Size(318, 114);
            this.picSeti.TabIndex = 2;
            this.picSeti.TabStop = false;
            // 
            // rdoSuspendBoinc
            // 
            this.rdoSuspendBoinc.AutoSize = true;
            this.rdoSuspendBoinc.Location = new System.Drawing.Point(93, 171);
            this.rdoSuspendBoinc.Name = "rdoSuspendBoinc";
            this.rdoSuspendBoinc.Size = new System.Drawing.Size(231, 24);
            this.rdoSuspendBoinc.TabIndex = 7;
            this.rdoSuspendBoinc.TabStop = true;
            this.rdoSuspendBoinc.Text = "Suspend ALL BOINC Tasks";
            this.rdoSuspendBoinc.UseVisualStyleBackColor = true;
            // 
            // rdoSuspendCPU
            // 
            this.rdoSuspendCPU.AutoSize = true;
            this.rdoSuspendCPU.Location = new System.Drawing.Point(330, 171);
            this.rdoSuspendCPU.Name = "rdoSuspendCPU";
            this.rdoSuspendCPU.Size = new System.Drawing.Size(235, 24);
            this.rdoSuspendCPU.TabIndex = 8;
            this.rdoSuspendCPU.TabStop = true;
            this.rdoSuspendCPU.Text = "Suspend CPU BOINC Tasks";
            this.rdoSuspendCPU.UseVisualStyleBackColor = true;
            // 
            // rdoSuspendGPU
            // 
            this.rdoSuspendGPU.AutoSize = true;
            this.rdoSuspendGPU.Location = new System.Drawing.Point(571, 171);
            this.rdoSuspendGPU.Name = "rdoSuspendGPU";
            this.rdoSuspendGPU.Size = new System.Drawing.Size(237, 24);
            this.rdoSuspendGPU.TabIndex = 9;
            this.rdoSuspendGPU.TabStop = true;
            this.rdoSuspendGPU.Text = "Suspend GPU BOINC Tasks";
            this.rdoSuspendGPU.UseVisualStyleBackColor = true;
            // 
            // numNoCPU
            // 
            this.numNoCPU.Location = new System.Drawing.Point(210, 215);
            this.numNoCPU.Name = "numNoCPU";
            this.numNoCPU.Size = new System.Drawing.Size(79, 26);
            this.numNoCPU.TabIndex = 10;
            this.numNoCPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumCPUs
            // 
            this.lblNumCPUs.AutoSize = true;
            this.lblNumCPUs.Location = new System.Drawing.Point(295, 218);
            this.lblNumCPUs.Name = "lblNumCPUs";
            this.lblNumCPUs.Size = new System.Drawing.Size(137, 20);
            this.lblNumCPUs.TabIndex = 11;
            this.lblNumCPUs.Text = "% of CPUs to Use";
            // 
            // lblPercCPU
            // 
            this.lblPercCPU.AutoSize = true;
            this.lblPercCPU.Location = new System.Drawing.Point(523, 218);
            this.lblPercCPU.Name = "lblPercCPU";
            this.lblPercCPU.Size = new System.Drawing.Size(167, 20);
            this.lblPercCPU.TabIndex = 13;
            this.lblPercCPU.Text = "% of CPU Time to Use";
            // 
            // numPercCPU
            // 
            this.numPercCPU.Location = new System.Drawing.Point(438, 215);
            this.numPercCPU.Name = "numPercCPU";
            this.numPercCPU.Size = new System.Drawing.Size(79, 26);
            this.numPercCPU.TabIndex = 12;
            this.numPercCPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 723);
            this.Controls.Add(this.lblPercCPU);
            this.Controls.Add(this.numPercCPU);
            this.Controls.Add(this.lblNumCPUs);
            this.Controls.Add(this.numNoCPU);
            this.Controls.Add(this.rdoSuspendGPU);
            this.Controls.Add(this.rdoSuspendCPU);
            this.Controls.Add(this.rdoSuspendBoinc);
            this.Controls.Add(this.btnGPUDetails);
            this.Controls.Add(this.tabOutput);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnRunBench);
            this.Controls.Add(this.picSeti);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seti KnaBench";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabOutput.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.PictureBox picSeti;
        private System.Windows.Forms.Button btnRunBench;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.ToolStripMenuItem uploadNewAppsToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabOutput;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtGpuDetails;
        private System.Windows.Forms.Button btnGPUDetails;
        private System.Windows.Forms.RadioButton rdoSuspendBoinc;
        private System.Windows.Forms.RadioButton rdoSuspendCPU;
        private System.Windows.Forms.RadioButton rdoSuspendGPU;
        private System.Windows.Forms.NumericUpDown numNoCPU;
        private System.Windows.Forms.Label lblNumCPUs;
        private System.Windows.Forms.Label lblPercCPU;
        private System.Windows.Forms.NumericUpDown numPercCPU;
    }
}

