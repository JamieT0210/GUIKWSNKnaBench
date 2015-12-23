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
            this.lstGPUValues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstGPUValues
            // 
            this.lstGPUValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGPUValues.FormattingEnabled = true;
            this.lstGPUValues.ItemHeight = 25;
            this.lstGPUValues.Location = new System.Drawing.Point(16, 30);
            this.lstGPUValues.Name = "lstGPUValues";
            this.lstGPUValues.Size = new System.Drawing.Size(457, 279);
            this.lstGPUValues.TabIndex = 0;
            // 
            // GPUMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 339);
            this.Controls.Add(this.lstGPUValues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GPUMonitor";
            this.Text = "GPU Monitor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstGPUValues;

    }
}