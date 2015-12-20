namespace KWSNKnaBench.Screens
{
    partial class GPUMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPUMonitor));
            this.txtGPUTemp = new System.Windows.Forms.TextBox();
            this.lblGPUTemp = new System.Windows.Forms.Label();
            this.lblFanSpeed = new System.Windows.Forms.Label();
            this.txtGPUFan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGPUFanSpeed = new System.Windows.Forms.TextBox();
            this.lblGPUMemory = new System.Windows.Forms.Label();
            this.txtGPUMem = new System.Windows.Forms.TextBox();
            this.lblGPUCore = new System.Windows.Forms.Label();
            this.txtGPUCore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGPUTemp
            // 
            this.txtGPUTemp.Location = new System.Drawing.Point(191, 44);
            this.txtGPUTemp.Name = "txtGPUTemp";
            this.txtGPUTemp.ReadOnly = true;
            this.txtGPUTemp.Size = new System.Drawing.Size(65, 26);
            this.txtGPUTemp.TabIndex = 0;
            this.txtGPUTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGPUTemp
            // 
            this.lblGPUTemp.AutoSize = true;
            this.lblGPUTemp.Location = new System.Drawing.Point(42, 50);
            this.lblGPUTemp.Name = "lblGPUTemp";
            this.lblGPUTemp.Size = new System.Drawing.Size(143, 20);
            this.lblGPUTemp.TabIndex = 2;
            this.lblGPUTemp.Text = "GPU Temperature:";
            // 
            // lblFanSpeed
            // 
            this.lblFanSpeed.AutoSize = true;
            this.lblFanSpeed.Location = new System.Drawing.Point(5, 84);
            this.lblFanSpeed.Name = "lblFanSpeed";
            this.lblFanSpeed.Size = new System.Drawing.Size(180, 20);
            this.lblFanSpeed.TabIndex = 4;
            this.lblFanSpeed.Text = "GPU Fan Speed (RPM):";
            // 
            // txtGPUFan
            // 
            this.txtGPUFan.Location = new System.Drawing.Point(191, 81);
            this.txtGPUFan.Name = "txtGPUFan";
            this.txtGPUFan.ReadOnly = true;
            this.txtGPUFan.Size = new System.Drawing.Size(65, 26);
            this.txtGPUFan.TabIndex = 3;
            this.txtGPUFan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "GPU Fan Speed %:";
            // 
            // txtGPUFanSpeed
            // 
            this.txtGPUFanSpeed.Location = new System.Drawing.Point(191, 114);
            this.txtGPUFanSpeed.Name = "txtGPUFanSpeed";
            this.txtGPUFanSpeed.ReadOnly = true;
            this.txtGPUFanSpeed.Size = new System.Drawing.Size(65, 26);
            this.txtGPUFanSpeed.TabIndex = 5;
            this.txtGPUFanSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGPUMemory
            // 
            this.lblGPUMemory.AutoSize = true;
            this.lblGPUMemory.Location = new System.Drawing.Point(59, 151);
            this.lblGPUMemory.Name = "lblGPUMemory";
            this.lblGPUMemory.Size = new System.Drawing.Size(126, 20);
            this.lblGPUMemory.TabIndex = 8;
            this.lblGPUMemory.Text = "GPU Memory %:";
            // 
            // txtGPUMem
            // 
            this.txtGPUMem.Location = new System.Drawing.Point(191, 148);
            this.txtGPUMem.Name = "txtGPUMem";
            this.txtGPUMem.ReadOnly = true;
            this.txtGPUMem.Size = new System.Drawing.Size(65, 26);
            this.txtGPUMem.TabIndex = 7;
            this.txtGPUMem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGPUCore
            // 
            this.lblGPUCore.AutoSize = true;
            this.lblGPUCore.Location = new System.Drawing.Point(297, 50);
            this.lblGPUCore.Name = "lblGPUCore";
            this.lblGPUCore.Size = new System.Drawing.Size(128, 20);
            this.lblGPUCore.TabIndex = 10;
            this.lblGPUCore.Text = "GPU Clock MHz:";
            // 
            // txtGPUCore
            // 
            this.txtGPUCore.Location = new System.Drawing.Point(431, 44);
            this.txtGPUCore.Name = "txtGPUCore";
            this.txtGPUCore.ReadOnly = true;
            this.txtGPUCore.Size = new System.Drawing.Size(65, 26);
            this.txtGPUCore.TabIndex = 9;
            this.txtGPUCore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GPUMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 244);
            this.Controls.Add(this.lblGPUCore);
            this.Controls.Add(this.txtGPUCore);
            this.Controls.Add(this.lblGPUMemory);
            this.Controls.Add(this.txtGPUMem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGPUFanSpeed);
            this.Controls.Add(this.lblFanSpeed);
            this.Controls.Add(this.txtGPUFan);
            this.Controls.Add(this.lblGPUTemp);
            this.Controls.Add(this.txtGPUTemp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GPUMonitor";
            this.Text = "GPU Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGPUTemp;
        private System.Windows.Forms.Label lblGPUTemp;
        private System.Windows.Forms.Label lblFanSpeed;
        private System.Windows.Forms.TextBox txtGPUFan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGPUFanSpeed;
        private System.Windows.Forms.Label lblGPUMemory;
        private System.Windows.Forms.TextBox txtGPUMem;
        private System.Windows.Forms.Label lblGPUCore;
        private System.Windows.Forms.TextBox txtGPUCore;
    }
}