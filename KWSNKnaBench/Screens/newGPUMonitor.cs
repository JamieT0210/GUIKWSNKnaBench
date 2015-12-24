using System;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

namespace KWSNKnaBench.Screens
{
    public partial class newGPUMonitor : Form
    {
        private string LastCharTemp = null;

        public newGPUMonitor()
        {
            InitializeComponent();
            var timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

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
                if ((Hardware.HardwareType == HardwareType.GpuNvidia) || (Hardware.HardwareType == HardwareType.GpuAti))
                {
                    char LastChar;
                    LastCharTemp = Convert.ToString(Hardware.Identifier);
                    LastChar = LastCharTemp[LastCharTemp.Length - 1];
                    cmbGPUs.Items.Add(Convert.ToString(Hardware.Identifier));
                    cmbGPUs.SelectedIndex = 0;
                    // cmbGPUs.Items.Add(String.Format(Hardware.Name) + " - Device: " + LastChar);
                }
            }
        }

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
                string selected = this.cmbGPUs.GetItemText(this.cmbGPUs.SelectedItem);
                if (Convert.ToString(Hardware.Identifier) == selected) 
                {
                    foreach (var sensor in Hardware.Sensors)
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            txtGpuTemp.Text = Convert.ToString(Math.Round((double)sensor.Value, 2));
                        }
                    foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Fan)
                    {
                        txtGPUFanSpeed.Text = Convert.ToString(Math.Round((double)sensor.Value, 2));
                    }
                    foreach (var sensor in Hardware.Sensors)
                        if (sensor.SensorType == SensorType.Control)
                        {
                            txtGpuFanPercent.Text = Convert.ToString(Math.Round((double)sensor.Value, 2));
                        }
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == selected + "/clock/0")
                        {
                            txtGPUCore.Text = Convert.ToString(Math.Round((double)sensor.Value, 2));
                        }
                    }
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == selected + "/clock/1")
                        {
                            txtGPUMem.Text = Convert.ToString(Math.Round((double)sensor.Value, 2));
                        }
                    }
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == selected + "/clock/2")
                        {
                            txtGPUShader.Text = Convert.ToString(Math.Round((double)sensor.Value, 2));
                        }
                    }
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == selected + "/load/0")
                        {
                            txtGPUCoreLoad.Text = Convert.ToString(Math.Round((double)sensor.Value, 2));
                        }
                    }
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == selected + "/load/3")
                        {
                            txtGPUMemLoadPerc.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    }
                }
            }
        }
    }
}