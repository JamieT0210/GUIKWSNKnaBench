using OpenHardwareMonitor.Hardware;
using System;
using System.Windows.Forms;

namespace KWSNKnaBench.Screens
{
    public partial class newGPUMonitor : Form
    {
      //  private string LastCharTemp = null;
        private string Selected = null;

        public newGPUMonitor()
        {
            InitializeComponent();
            var timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }
        //This button is hidden and called on a form_load event
        private void button1_Click(object sender, EventArgs e)
        {
            Computer c = new Computer()
            {
                GPUEnabled = true,
            };
            c.Open();

            foreach (var Hardware in c.Hardware)
            {
                Hardware.Update();
                //Print the GPU name into a dropdown list
                if ((Hardware.HardwareType == HardwareType.GpuNvidia) || (Hardware.HardwareType == HardwareType.GpuAti))
                {
                    cmbGPUs.Items.Add(String.Format(Hardware.Name) + ": " + Convert.ToString(Hardware.Identifier));
                    cmbGPUs.SelectedIndex = 0;
                }
            }
        }

        //Constantly refresh the values
        void timer_Tick(object sender, EventArgs e)
        {
            Computer c = new Computer()
            {
                GPUEnabled = true
            };
            c.Open();
            foreach (var Hardware in c.Hardware)
            {
                Hardware.Update();
                string str = this.cmbGPUs.GetItemText(this.cmbGPUs.SelectedItem);
                Selected = str.Substring(str.LastIndexOf(' ') + 1);
                if (Convert.ToString(Hardware.Identifier) == Selected) 
                {
                    //Temperature
                    foreach (var sensor in Hardware.Sensors)
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            txtGpuTemp.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    //Fan speed RPM
                    foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Fan)
                    {
                        txtGPUFanSpeed.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                    }
                    //Fan Speed % 
                    foreach (var sensor in Hardware.Sensors)
                        if (sensor.SensorType == SensorType.Control)
                        {
                            txtGpuFanPercent.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    //Core Clock
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == Selected + "/clock/0")
                        {
                            txtGPUCore.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    }
                    //Memory clock
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == Selected + "/clock/1")
                        {
                            txtGPUMem.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    }
                    //Shader clock
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == Selected + "/clock/2")
                        {
                            txtGPUShader.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    }
                    //Core Load
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == Selected + "/load/0")
                        {
                            txtGPUCoreLoad.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    }
                    //Memory Load
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == Selected + "/load/3")
                        {
                            txtGPUMemLoadPerc.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    }
                }
            }
        }
        //Close the screen
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}