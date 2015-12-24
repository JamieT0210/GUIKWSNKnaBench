namespace KWSNKnaBench
{
    partial class SciAppUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SciAppUpload));
            this.chkBoxRef = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtNewSciApps = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.chkMoveDll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkBoxRef
            // 
            this.chkBoxRef.AutoSize = true;
            this.chkBoxRef.Location = new System.Drawing.Point(133, 31);
            this.chkBoxRef.Name = "chkBoxRef";
            this.chkBoxRef.Size = new System.Drawing.Size(335, 24);
            this.chkBoxRef.TabIndex = 0;
            this.chkBoxRef.Text = "Use Old Science Apps as Reference Apps";
            this.chkBoxRef.UseVisualStyleBackColor = true;
            // 
            // txtNewSciApps
            // 
            this.txtNewSciApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewSciApps.Location = new System.Drawing.Point(43, 86);
            this.txtNewSciApps.Name = "txtNewSciApps";
            this.txtNewSciApps.Size = new System.Drawing.Size(622, 30);
            this.txtNewSciApps.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(671, 81);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(112, 43);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(340, 163);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(146, 84);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload New Science Apps";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // chkMoveDll
            // 
            this.chkMoveDll.AutoSize = true;
            this.chkMoveDll.Location = new System.Drawing.Point(474, 31);
            this.chkMoveDll.Name = "chkMoveDll";
            this.chkMoveDll.Size = new System.Drawing.Size(223, 24);
            this.chkMoveDll.TabIndex = 4;
            this.chkMoveDll.Text = "Move .dll\'s as well as .exe\'s";
            this.chkMoveDll.UseVisualStyleBackColor = true;
            // 
            // SciAppUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 274);
            this.Controls.Add(this.chkMoveDll);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtNewSciApps);
            this.Controls.Add(this.chkBoxRef);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SciAppUpload";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Science Apps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBoxRef;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtNewSciApps;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.CheckBox chkMoveDll;
    }
}