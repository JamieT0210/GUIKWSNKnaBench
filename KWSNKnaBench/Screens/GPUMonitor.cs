using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;

namespace KWSNKnaBench.Screens
{
    public partial class GPUMonitor : Form
    {
        public GPUMonitor()
        {
       //     InitializeComponent();
            InitializeComponent();
            var timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000; 
            timer.Start();
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
                if (Hardware.HardwareType == HardwareType.GpuNvidia) Hardware.Update();
                foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Temperature) txtGPUTemp.Text = Convert.ToString(sensor.Value);
            }
            foreach (var Hardware in c.Hardware)
            {
                if (Hardware.HardwareType == HardwareType.GpuNvidia) Hardware.Update();
                foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Fan) txtGPUFan.Text = Convert.ToString(sensor.Value);
            }
            foreach (var Hardware in c.Hardware)
            {
                if (Hardware.HardwareType == HardwareType.GpuNvidia) Hardware.Update();
                foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Control) txtGPUFanSpeed.Text = Convert.ToString(sensor.Value);
            }
            foreach (var Hardware in c.Hardware)
            {
                if (Hardware.HardwareType == HardwareType.GpuNvidia) Hardware.Update();
                foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Load) txtGPUMem.Text = Convert.ToString(Math.Round((double)sensor.Value, 1));
            }
            foreach (var Hardware in c.Hardware)
            {
                if (Hardware.HardwareType == HardwareType.GpuNvidia) Hardware.Update();
                foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Clock) txtGPUCore.Text = Convert.ToString(Math.Round((double)sensor.Value / 2, 1));
            }
        }
    }
}