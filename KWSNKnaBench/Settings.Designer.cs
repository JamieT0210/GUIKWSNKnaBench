namespace KWSNKnaBench
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.txtBenchLoc = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSMTPServer = new System.Windows.Forms.TextBox();
            this.lblEmailServer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSMTPPort = new System.Windows.Forms.Label();
            this.txtSMTPPort = new System.Windows.Forms.TextBox();
            this.lblEmailUser = new System.Windows.Forms.Label();
            this.txtEmailUser = new System.Windows.Forms.TextBox();
            this.lblEmailPassword = new System.Windows.Forms.Label();
            this.txtEmailPass = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkBoxShowPwd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBenchLoc
            // 
            this.txtBenchLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenchLoc.Location = new System.Drawing.Point(260, 26);
            this.txtBenchLoc.Name = "txtBenchLoc";
            this.txtBenchLoc.Size = new System.Drawing.Size(809, 30);
            this.txtBenchLoc.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1075, 26);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 32);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(699, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSMTPServer
            // 
            this.txtSMTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTPServer.Location = new System.Drawing.Point(260, 62);
            this.txtSMTPServer.Name = "txtSMTPServer";
            this.txtSMTPServer.Size = new System.Drawing.Size(809, 30);
            this.txtSMTPServer.TabIndex = 2;
            // 
            // lblEmailServer
            // 
            this.lblEmailServer.AutoSize = true;
            this.lblEmailServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailServer.Location = new System.Drawing.Point(65, 67);
            this.lblEmailServer.Name = "lblEmailServer";
            this.lblEmailServer.Size = new System.Drawing.Size(178, 22);
            this.lblEmailServer.TabIndex = 4;
            this.lblEmailServer.Text = "E-mail SMTP Server:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Benchmark Folder Location:";
            // 
            // lblSMTPPort
            // 
            this.lblSMTPPort.AutoSize = true;
            this.lblSMTPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMTPPort.Location = new System.Drawing.Point(85, 106);
            this.lblSMTPPort.Name = "lblSMTPPort";
            this.lblSMTPPort.Size = new System.Drawing.Size(158, 22);
            this.lblSMTPPort.TabIndex = 7;
            this.lblSMTPPort.Text = "E-mail SMTP Port:";
            // 
            // txtSMTPPort
            // 
            this.txtSMTPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMTPPort.Location = new System.Drawing.Point(260, 101);
            this.txtSMTPPort.Name = "txtSMTPPort";
            this.txtSMTPPort.Size = new System.Drawing.Size(809, 30);
            this.txtSMTPPort.TabIndex = 3;
            // 
            // lblEmailUser
            // 
            this.lblEmailUser.AutoSize = true;
            this.lblEmailUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUser.Location = new System.Drawing.Point(91, 142);
            this.lblEmailUser.Name = "lblEmailUser";
            this.lblEmailUser.Size = new System.Drawing.Size(152, 22);
            this.lblEmailUser.TabIndex = 9;
            this.lblEmailUser.Text = "E-mail Username:";
            this.lblEmailUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUser.Location = new System.Drawing.Point(260, 137);
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(809, 30);
            this.txtEmailUser.TabIndex = 4;
            // 
            // lblEmailPassword
            // 
            this.lblEmailPassword.AutoSize = true;
            this.lblEmailPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPassword.Location = new System.Drawing.Point(94, 178);
            this.lblEmailPassword.Name = "lblEmailPassword";
            this.lblEmailPassword.Size = new System.Drawing.Size(149, 22);
            this.lblEmailPassword.TabIndex = 11;
            this.lblEmailPassword.Text = "E-mail Password:";
            this.lblEmailPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmailPass
            // 
            this.txtEmailPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPass.Location = new System.Drawing.Point(260, 173);
            this.txtEmailPass.Name = "txtEmailPass";
            this.txtEmailPass.Size = new System.Drawing.Size(809, 30);
            this.txtEmailPass.TabIndex = 5;
            this.txtEmailPass.UseSystemPasswordChar = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(309, 209);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(148, 46);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh Settings";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(497, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 46);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Settings";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkBoxShowPwd
            // 
            this.chkBoxShowPwd.AutoSize = true;
            this.chkBoxShowPwd.Location = new System.Drawing.Point(1076, 178);
            this.chkBoxShowPwd.Name = "chkBoxShowPwd";
            this.chkBoxShowPwd.Size = new System.Drawing.Size(148, 24);
            this.chkBoxShowPwd.TabIndex = 15;
            this.chkBoxShowPwd.Text = "Show Password";
            this.chkBoxShowPwd.UseVisualStyleBackColor = true;
            this.chkBoxShowPwd.CheckedChanged += new System.EventHandler(this.chkBoxShowPwd_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 281);
            this.Controls.Add(this.chkBoxShowPwd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblEmailPassword);
            this.Controls.Add(this.txtEmailPass);
            this.Controls.Add(this.lblEmailUser);
            this.Controls.Add(this.txtEmailUser);
            this.Controls.Add(this.lblSMTPPort);
            this.Controls.Add(this.txtSMTPPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmailServer);
            this.Controls.Add(this.txtSMTPServer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBenchLoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBenchLoc;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSMTPServer;
        private System.Windows.Forms.Label lblEmailServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSMTPPort;
        private System.Windows.Forms.TextBox txtSMTPPort;
        private System.Windows.Forms.Label lblEmailUser;
        private System.Windows.Forms.TextBox txtEmailUser;
        private System.Windows.Forms.Label lblEmailPassword;
        private System.Windows.Forms.TextBox txtEmailPass;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkBoxShowPwd;
    }
}