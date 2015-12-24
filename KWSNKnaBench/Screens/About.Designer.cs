namespace KWSNKnaBench
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lblAbout1 = new System.Windows.Forms.Label();
            this.lblAbout2 = new System.Windows.Forms.Label();
            this.lblAbout3 = new System.Windows.Forms.Label();
            this.lblAbout4 = new System.Windows.Forms.Label();
            this.lblAbout5 = new System.Windows.Forms.Label();
            this.hypJGOPT = new System.Windows.Forms.LinkLabel();
            this.hypLunatics = new System.Windows.Forms.LinkLabel();
            this.lblCrunchAnon = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblAbout1
            // 
            this.lblAbout1.AutoSize = true;
            this.lblAbout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout1.Location = new System.Drawing.Point(49, 13);
            this.lblAbout1.Name = "lblAbout1";
            this.lblAbout1.Size = new System.Drawing.Size(582, 22);
            this.lblAbout1.TabIndex = 0;
            this.lblAbout1.Text = "MB Knabench 2.14 W32-W64 2014-07-14 by Kna + Simon + Joe";
            // 
            // lblAbout2
            // 
            this.lblAbout2.AutoSize = true;
            this.lblAbout2.Location = new System.Drawing.Point(143, 46);
            this.lblAbout2.Name = "lblAbout2";
            this.lblAbout2.Size = new System.Drawing.Size(395, 20);
            this.lblAbout2.TabIndex = 1;
            this.lblAbout2.Text = "mods: quick timetable, stderr, speedup/ratio, AppTimes";
            // 
            // lblAbout3
            // 
            this.lblAbout3.AutoSize = true;
            this.lblAbout3.Location = new System.Drawing.Point(278, 76);
            this.lblAbout3.Name = "lblAbout3";
            this.lblAbout3.Size = new System.Drawing.Size(124, 20);
            this.lblAbout3.TabIndex = 2;
            this.lblAbout3.Text = "/ref/ by Raistmer";
            // 
            // lblAbout4
            // 
            this.lblAbout4.AutoSize = true;
            this.lblAbout4.Location = new System.Drawing.Point(172, 108);
            this.lblAbout4.Name = "lblAbout4";
            this.lblAbout4.Size = new System.Drawing.Size(336, 20);
            this.lblAbout4.TabIndex = 3;
            this.lblAbout4.Text = "BOINC install detection by Richard Haselgrove";
            // 
            // lblAbout5
            // 
            this.lblAbout5.AutoSize = true;
            this.lblAbout5.Location = new System.Drawing.Point(246, 140);
            this.lblAbout5.Name = "lblAbout5";
            this.lblAbout5.Size = new System.Drawing.Size(188, 20);
            this.lblAbout5.TabIndex = 4;
            this.lblAbout5.Text = "GUI Conversion by Jamie";
            // 
            // hypJGOPT
            // 
            this.hypJGOPT.AutoSize = true;
            this.hypJGOPT.Location = new System.Drawing.Point(193, 166);
            this.hypJGOPT.Name = "hypJGOPT";
            this.hypJGOPT.Size = new System.Drawing.Size(44, 20);
            this.hypJGOPT.TabIndex = 5;
            this.hypJGOPT.TabStop = true;
            this.hypJGOPT.Text = "jgopt";
            this.hypJGOPT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hypJGOPT_LinkClicked);
            // 
            // hypLunatics
            // 
            this.hypLunatics.AutoSize = true;
            this.hypLunatics.Location = new System.Drawing.Point(419, 166);
            this.hypLunatics.Name = "hypLunatics";
            this.hypLunatics.Size = new System.Drawing.Size(69, 20);
            this.hypLunatics.TabIndex = 6;
            this.hypLunatics.TabStop = true;
            this.hypLunatics.Text = "Lunatics";
            this.hypLunatics.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hypLunatics_LinkClicked);
            // 
            // lblCrunchAnon
            // 
            this.lblCrunchAnon.AutoSize = true;
            this.lblCrunchAnon.Location = new System.Drawing.Point(243, 166);
            this.lblCrunchAnon.Name = "lblCrunchAnon";
            this.lblCrunchAnon.Size = new System.Drawing.Size(170, 20);
            this.lblCrunchAnon.TabIndex = 7;
            this.lblCrunchAnon.TabStop = true;
            this.lblCrunchAnon.Text = "Crunchers Anonymous";
            this.lblCrunchAnon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCrunchAnon_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 195);
            this.Controls.Add(this.lblCrunchAnon);
            this.Controls.Add(this.hypLunatics);
            this.Controls.Add(this.hypJGOPT);
            this.Controls.Add(this.lblAbout5);
            this.Controls.Add(this.lblAbout4);
            this.Controls.Add(this.lblAbout3);
            this.Controls.Add(this.lblAbout2);
            this.Controls.Add(this.lblAbout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About KWSNKnaBench 1.0.8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout1;
        private System.Windows.Forms.Label lblAbout2;
        private System.Windows.Forms.Label lblAbout3;
        private System.Windows.Forms.Label lblAbout4;
        private System.Windows.Forms.Label lblAbout5;
        private System.Windows.Forms.LinkLabel hypJGOPT;
        private System.Windows.Forms.LinkLabel hypLunatics;
        private System.Windows.Forms.LinkLabel lblCrunchAnon;
    }
}