namespace KWSNKnaBench.Screens
{
    partial class newGPUMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newGPUMonitor));
            this.txtGpuTemp = new System.Windows.Forms.TextBox();
            this.cmbGPUs = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpTemp = new System.Windows.Forms.GroupBox();
            this.grpFanSpeed = new System.Windows.Forms.GroupBox();
            this.txtGPUFanSpeed = new System.Windows.Forms.TextBox();
            this.grpFanPerc = new System.Windows.Forms.GroupBox();
            this.txtGpuFanPercent = new System.Windows.Forms.TextBox();
            this.grpShader = new System.Windows.Forms.GroupBox();
            this.txtGPUShader = new System.Windows.Forms.TextBox();
            this.grpMemClock = new System.Windows.Forms.GroupBox();
            this.txtGPUMem = new System.Windows.Forms.TextBox();
            this.grpCoreClock = new System.Windows.Forms.GroupBox();
            this.txtGPUCore = new System.Windows.Forms.TextBox();
            this.grpGPUMemLoad = new System.Windows.Forms.GroupBox();
            this.txtGPUMemLoadPerc = new System.Windows.Forms.TextBox();
            this.grpGPUCoreLoad = new System.Windows.Forms.GroupBox();
            this.txtGPUCoreLoad = new System.Windows.Forms.TextBox();
            this.picGPMShader = new System.Windows.Forms.PictureBox();
            this.picGPUMemLoadPerc = new System.Windows.Forms.PictureBox();
            this.picCoreLoad = new System.Windows.Forms.PictureBox();
            this.picGPUFanPerc = new System.Windows.Forms.PictureBox();
            this.picGPUMem = new System.Windows.Forms.PictureBox();
            this.picGPUCore = new System.Windows.Forms.PictureBox();
            this.picGPUFanSpeed = new System.Windows.Forms.PictureBox();
            this.picGPUTemp = new System.Windows.Forms.PictureBox();
            this.grpTemp.SuspendLayout();
            this.grpFanSpeed.SuspendLayout();
            this.grpFanPerc.SuspendLayout();
            this.grpShader.SuspendLayout();
            this.grpMemClock.SuspendLayout();
            this.grpCoreClock.SuspendLayout();
            this.grpGPUMemLoad.SuspendLayout();
            this.grpGPUCoreLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGPMShader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUMemLoadPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoreLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUFanPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUCore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUFanSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGpuTemp
            // 
            this.txtGpuTemp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGpuTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGpuTemp.Enabled = false;
            this.txtGpuTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGpuTemp.Location = new System.Drawing.Point(36, 159);
            this.txtGpuTemp.Name = "txtGpuTemp";
            this.txtGpuTemp.ReadOnly = true;
            this.txtGpuTemp.Size = new System.Drawing.Size(100, 23);
            this.txtGpuTemp.TabIndex = 0;
            this.txtGpuTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbGPUs
            // 
            this.cmbGPUs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGPUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGPUs.FormattingEnabled = true;
            this.cmbGPUs.Location = new System.Drawing.Point(88, 33);
            this.cmbGPUs.Name = "cmbGPUs";
            this.cmbGPUs.Size = new System.Drawing.Size(417, 33);
            this.cmbGPUs.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpTemp
            // 
            this.grpTemp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpTemp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpTemp.Controls.Add(this.picGPUTemp);
            this.grpTemp.Controls.Add(this.txtGpuTemp);
            this.grpTemp.Enabled = false;
            this.grpTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTemp.Location = new System.Drawing.Point(31, 85);
            this.grpTemp.Name = "grpTemp";
            this.grpTemp.Size = new System.Drawing.Size(173, 201);
            this.grpTemp.TabIndex = 4;
            this.grpTemp.TabStop = false;
            this.grpTemp.Text = "Temperature °C:";
            // 
            // grpFanSpeed
            // 
            this.grpFanSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpFanSpeed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpFanSpeed.Controls.Add(this.picGPUFanSpeed);
            this.grpFanSpeed.Controls.Add(this.txtGPUFanSpeed);
            this.grpFanSpeed.Enabled = false;
            this.grpFanSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFanSpeed.Location = new System.Drawing.Point(210, 85);
            this.grpFanSpeed.Name = "grpFanSpeed";
            this.grpFanSpeed.Size = new System.Drawing.Size(173, 201);
            this.grpFanSpeed.TabIndex = 5;
            this.grpFanSpeed.TabStop = false;
            this.grpFanSpeed.Text = "Fan Speed RPM:";
            // 
            // txtGPUFanSpeed
            // 
            this.txtGPUFanSpeed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGPUFanSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGPUFanSpeed.Enabled = false;
            this.txtGPUFanSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPUFanSpeed.Location = new System.Drawing.Point(36, 159);
            this.txtGPUFanSpeed.Name = "txtGPUFanSpeed";
            this.txtGPUFanSpeed.ReadOnly = true;
            this.txtGPUFanSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtGPUFanSpeed.TabIndex = 0;
            this.txtGPUFanSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpFanPerc
            // 
            this.grpFanPerc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpFanPerc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpFanPerc.Controls.Add(this.picGPUFanPerc);
            this.grpFanPerc.Controls.Add(this.txtGpuFanPercent);
            this.grpFanPerc.Enabled = false;
            this.grpFanPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFanPerc.Location = new System.Drawing.Point(389, 85);
            this.grpFanPerc.Name = "grpFanPerc";
            this.grpFanPerc.Size = new System.Drawing.Size(173, 201);
            this.grpFanPerc.TabIndex = 6;
            this.grpFanPerc.TabStop = false;
            this.grpFanPerc.Text = "Fan Speed %:";
            // 
            // txtGpuFanPercent
            // 
            this.txtGpuFanPercent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGpuFanPercent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGpuFanPercent.Enabled = false;
            this.txtGpuFanPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGpuFanPercent.Location = new System.Drawing.Point(36, 159);
            this.txtGpuFanPercent.Name = "txtGpuFanPercent";
            this.txtGpuFanPercent.ReadOnly = true;
            this.txtGpuFanPercent.Size = new System.Drawing.Size(100, 23);
            this.txtGpuFanPercent.TabIndex = 0;
            this.txtGpuFanPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpShader
            // 
            this.grpShader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpShader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpShader.Controls.Add(this.picGPMShader);
            this.grpShader.Controls.Add(this.txtGPUShader);
            this.grpShader.Enabled = false;
            this.grpShader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShader.Location = new System.Drawing.Point(389, 292);
            this.grpShader.Name = "grpShader";
            this.grpShader.Size = new System.Drawing.Size(173, 201);
            this.grpShader.TabIndex = 9;
            this.grpShader.TabStop = false;
            this.grpShader.Text = "Shader MHz:";
            // 
            // txtGPUShader
            // 
            this.txtGPUShader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGPUShader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGPUShader.Enabled = false;
            this.txtGPUShader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPUShader.Location = new System.Drawing.Point(36, 159);
            this.txtGPUShader.Name = "txtGPUShader";
            this.txtGPUShader.ReadOnly = true;
            this.txtGPUShader.Size = new System.Drawing.Size(100, 23);
            this.txtGPUShader.TabIndex = 0;
            this.txtGPUShader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpMemClock
            // 
            this.grpMemClock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpMemClock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpMemClock.Controls.Add(this.picGPUMem);
            this.grpMemClock.Controls.Add(this.txtGPUMem);
            this.grpMemClock.Enabled = false;
            this.grpMemClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMemClock.Location = new System.Drawing.Point(210, 292);
            this.grpMemClock.Name = "grpMemClock";
            this.grpMemClock.Size = new System.Drawing.Size(173, 201);
            this.grpMemClock.TabIndex = 8;
            this.grpMemClock.TabStop = false;
            this.grpMemClock.Text = "Memory MHz:";
            // 
            // txtGPUMem
            // 
            this.txtGPUMem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGPUMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGPUMem.Enabled = false;
            this.txtGPUMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPUMem.Location = new System.Drawing.Point(36, 159);
            this.txtGPUMem.Name = "txtGPUMem";
            this.txtGPUMem.ReadOnly = true;
            this.txtGPUMem.Size = new System.Drawing.Size(100, 23);
            this.txtGPUMem.TabIndex = 0;
            this.txtGPUMem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpCoreClock
            // 
            this.grpCoreClock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpCoreClock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpCoreClock.Controls.Add(this.picGPUCore);
            this.grpCoreClock.Controls.Add(this.txtGPUCore);
            this.grpCoreClock.Enabled = false;
            this.grpCoreClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCoreClock.Location = new System.Drawing.Point(31, 292);
            this.grpCoreClock.Name = "grpCoreClock";
            this.grpCoreClock.Size = new System.Drawing.Size(173, 201);
            this.grpCoreClock.TabIndex = 7;
            this.grpCoreClock.TabStop = false;
            this.grpCoreClock.Text = "Core MHz:";
            // 
            // txtGPUCore
            // 
            this.txtGPUCore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGPUCore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGPUCore.Enabled = false;
            this.txtGPUCore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPUCore.Location = new System.Drawing.Point(36, 159);
            this.txtGPUCore.Name = "txtGPUCore";
            this.txtGPUCore.ReadOnly = true;
            this.txtGPUCore.Size = new System.Drawing.Size(100, 23);
            this.txtGPUCore.TabIndex = 0;
            this.txtGPUCore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpGPUMemLoad
            // 
            this.grpGPUMemLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpGPUMemLoad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpGPUMemLoad.Controls.Add(this.picGPUMemLoadPerc);
            this.grpGPUMemLoad.Controls.Add(this.txtGPUMemLoadPerc);
            this.grpGPUMemLoad.Enabled = false;
            this.grpGPUMemLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGPUMemLoad.Location = new System.Drawing.Point(299, 499);
            this.grpGPUMemLoad.Name = "grpGPUMemLoad";
            this.grpGPUMemLoad.Size = new System.Drawing.Size(173, 201);
            this.grpGPUMemLoad.TabIndex = 11;
            this.grpGPUMemLoad.TabStop = false;
            this.grpGPUMemLoad.Text = "Memory Load %:";
            // 
            // txtGPUMemLoadPerc
            // 
            this.txtGPUMemLoadPerc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGPUMemLoadPerc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGPUMemLoadPerc.Enabled = false;
            this.txtGPUMemLoadPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPUMemLoadPerc.Location = new System.Drawing.Point(36, 159);
            this.txtGPUMemLoadPerc.Name = "txtGPUMemLoadPerc";
            this.txtGPUMemLoadPerc.ReadOnly = true;
            this.txtGPUMemLoadPerc.Size = new System.Drawing.Size(100, 23);
            this.txtGPUMemLoadPerc.TabIndex = 0;
            this.txtGPUMemLoadPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpGPUCoreLoad
            // 
            this.grpGPUCoreLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpGPUCoreLoad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpGPUCoreLoad.Controls.Add(this.picCoreLoad);
            this.grpGPUCoreLoad.Controls.Add(this.txtGPUCoreLoad);
            this.grpGPUCoreLoad.Enabled = false;
            this.grpGPUCoreLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGPUCoreLoad.Location = new System.Drawing.Point(120, 499);
            this.grpGPUCoreLoad.Name = "grpGPUCoreLoad";
            this.grpGPUCoreLoad.Size = new System.Drawing.Size(173, 201);
            this.grpGPUCoreLoad.TabIndex = 10;
            this.grpGPUCoreLoad.TabStop = false;
            this.grpGPUCoreLoad.Text = "Core Load %";
            // 
            // txtGPUCoreLoad
            // 
            this.txtGPUCoreLoad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGPUCoreLoad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGPUCoreLoad.Enabled = false;
            this.txtGPUCoreLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPUCoreLoad.Location = new System.Drawing.Point(36, 159);
            this.txtGPUCoreLoad.Name = "txtGPUCoreLoad";
            this.txtGPUCoreLoad.ReadOnly = true;
            this.txtGPUCoreLoad.Size = new System.Drawing.Size(100, 23);
            this.txtGPUCoreLoad.TabIndex = 0;
            this.txtGPUCoreLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picGPMShader
            // 
            this.picGPMShader.Image = global::KWSNKnaBench.Properties.Resources.clock;
            this.picGPMShader.Location = new System.Drawing.Point(36, 25);
            this.picGPMShader.Name = "picGPMShader";
            this.picGPMShader.Size = new System.Drawing.Size(100, 128);
            this.picGPMShader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGPMShader.TabIndex = 3;
            this.picGPMShader.TabStop = false;
            // 
            // picGPUMemLoadPerc
            // 
            this.picGPUMemLoadPerc.Image = global::KWSNKnaBench.Properties.Resources.performance_clock_speed_512;
            this.picGPUMemLoadPerc.Location = new System.Drawing.Point(36, 25);
            this.picGPUMemLoadPerc.Name = "picGPUMemLoadPerc";
            this.picGPUMemLoadPerc.Size = new System.Drawing.Size(100, 128);
            this.picGPUMemLoadPerc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGPUMemLoadPerc.TabIndex = 3;
            this.picGPUMemLoadPerc.TabStop = false;
            // 
            // picCoreLoad
            // 
            this.picCoreLoad.Image = global::KWSNKnaBench.Properties.Resources.performance_clock_speed_512;
            this.picCoreLoad.Location = new System.Drawing.Point(36, 25);
            this.picCoreLoad.Name = "picCoreLoad";
            this.picCoreLoad.Size = new System.Drawing.Size(100, 128);
            this.picCoreLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCoreLoad.TabIndex = 3;
            this.picCoreLoad.TabStop = false;
            // 
            // picGPUFanPerc
            // 
            this.picGPUFanPerc.Image = global::KWSNKnaBench.Properties.Resources.fan;
            this.picGPUFanPerc.Location = new System.Drawing.Point(36, 25);
            this.picGPUFanPerc.Name = "picGPUFanPerc";
            this.picGPUFanPerc.Size = new System.Drawing.Size(100, 128);
            this.picGPUFanPerc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGPUFanPerc.TabIndex = 3;
            this.picGPUFanPerc.TabStop = false;
            // 
            // picGPUMem
            // 
            this.picGPUMem.Image = global::KWSNKnaBench.Properties.Resources.clock;
            this.picGPUMem.Location = new System.Drawing.Point(36, 25);
            this.picGPUMem.Name = "picGPUMem";
            this.picGPUMem.Size = new System.Drawing.Size(100, 128);
            this.picGPUMem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGPUMem.TabIndex = 3;
            this.picGPUMem.TabStop = false;
            // 
            // picGPUCore
            // 
            this.picGPUCore.Image = global::KWSNKnaBench.Properties.Resources.clock;
            this.picGPUCore.Location = new System.Drawing.Point(36, 25);
            this.picGPUCore.Name = "picGPUCore";
            this.picGPUCore.Size = new System.Drawing.Size(100, 128);
            this.picGPUCore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGPUCore.TabIndex = 3;
            this.picGPUCore.TabStop = false;
            // 
            // picGPUFanSpeed
            // 
            this.picGPUFanSpeed.Image = global::KWSNKnaBench.Properties.Resources.fan;
            this.picGPUFanSpeed.Location = new System.Drawing.Point(36, 25);
            this.picGPUFanSpeed.Name = "picGPUFanSpeed";
            this.picGPUFanSpeed.Size = new System.Drawing.Size(100, 128);
            this.picGPUFanSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGPUFanSpeed.TabIndex = 3;
            this.picGPUFanSpeed.TabStop = false;
            // 
            // picGPUTemp
            // 
            this.picGPUTemp.Image = global::KWSNKnaBench.Properties.Resources.thermometer1;
            this.picGPUTemp.Location = new System.Drawing.Point(36, 25);
            this.picGPUTemp.Name = "picGPUTemp";
            this.picGPUTemp.Size = new System.Drawing.Size(100, 128);
            this.picGPUTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGPUTemp.TabIndex = 3;
            this.picGPUTemp.TabStop = false;
            // 
            // newGPUMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 732);
            this.Controls.Add(this.grpShader);
            this.Controls.Add(this.grpGPUMemLoad);
            this.Controls.Add(this.grpGPUCoreLoad);
            this.Controls.Add(this.grpFanPerc);
            this.Controls.Add(this.grpMemClock);
            this.Controls.Add(this.grpCoreClock);
            this.Controls.Add(this.grpFanSpeed);
            this.Controls.Add(this.grpTemp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbGPUs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newGPUMonitor";
            this.Text = "GPU Monitor";
            this.Load += new System.EventHandler(this.button1_Click);
            this.grpTemp.ResumeLayout(false);
            this.grpTemp.PerformLayout();
            this.grpFanSpeed.ResumeLayout(false);
            this.grpFanSpeed.PerformLayout();
            this.grpFanPerc.ResumeLayout(false);
            this.grpFanPerc.PerformLayout();
            this.grpShader.ResumeLayout(false);
            this.grpShader.PerformLayout();
            this.grpMemClock.ResumeLayout(false);
            this.grpMemClock.PerformLayout();
            this.grpCoreClock.ResumeLayout(false);
            this.grpCoreClock.PerformLayout();
            this.grpGPUMemLoad.ResumeLayout(false);
            this.grpGPUMemLoad.PerformLayout();
            this.grpGPUCoreLoad.ResumeLayout(false);
            this.grpGPUCoreLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGPMShader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUMemLoadPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoreLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUFanPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUCore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUFanSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGPUTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGpuTemp;
        private System.Windows.Forms.ComboBox cmbGPUs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picGPUTemp;
        private System.Windows.Forms.GroupBox grpTemp;
        private System.Windows.Forms.GroupBox grpFanSpeed;
        private System.Windows.Forms.PictureBox picGPUFanSpeed;
        private System.Windows.Forms.TextBox txtGPUFanSpeed;
        private System.Windows.Forms.GroupBox grpFanPerc;
        private System.Windows.Forms.PictureBox picGPUFanPerc;
        private System.Windows.Forms.TextBox txtGpuFanPercent;
        private System.Windows.Forms.GroupBox grpShader;
        private System.Windows.Forms.PictureBox picGPMShader;
        private System.Windows.Forms.TextBox txtGPUShader;
        private System.Windows.Forms.GroupBox grpMemClock;
        private System.Windows.Forms.PictureBox picGPUMem;
        private System.Windows.Forms.TextBox txtGPUMem;
        private System.Windows.Forms.GroupBox grpCoreClock;
        private System.Windows.Forms.PictureBox picGPUCore;
        private System.Windows.Forms.TextBox txtGPUCore;
        private System.Windows.Forms.GroupBox grpGPUMemLoad;
        private System.Windows.Forms.PictureBox picGPUMemLoadPerc;
        private System.Windows.Forms.TextBox txtGPUMemLoadPerc;
        private System.Windows.Forms.GroupBox grpGPUCoreLoad;
        private System.Windows.Forms.PictureBox picCoreLoad;
        private System.Windows.Forms.TextBox txtGPUCoreLoad;
    }
}