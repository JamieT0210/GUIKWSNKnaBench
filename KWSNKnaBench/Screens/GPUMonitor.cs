using System;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

//All values here are taken from the Open Source Open Hardware Monitor Library
//And are refreshed frequently
//I think this should only return device 0 values
//But need a multi-GPU host to test this
//Should return values for either a Nvidia or ATI GPU

namespace KWSNKnaBench.Screens
{
    public partial class GPUMonitor : Form
    {
   
        public GPUMonitor()
        {
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
                //Enabled the GPU Settings
                GPUEnabled = true
            };
            c.Open();
            //Clear oput the list box
            lstGPUValues.Items.Clear();

            //For each hardware type get a value if one exists
            //Print the GPU Name
            foreach (var Hardware in c.Hardware)
            {
                if ((Hardware.HardwareType == HardwareType.GpuNvidia) || (Hardware.HardwareType == HardwareType.GpuAti))
                {
                    Hardware.Update();
                    string LastCharTemp = null;
                    char LastChar;
                    LastCharTemp = Convert.ToString(Hardware.Identifier);
                    LastChar = LastCharTemp[LastCharTemp.Length - 1];
                    lstGPUValues.Items.Add(String.Format(Hardware.Name) + " - Device: " + LastChar);
                }
            }
            foreach (var Hardware in c.Hardware)
            {
                if ((Hardware.HardwareType == HardwareType.GpuNvidia) || (Hardware.HardwareType == HardwareType.GpuAti))
                {
                    Hardware.Update();
                }
                //Core Temp
                foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        lstGPUValues.Items.Add(String.Format("{0} Temperature = {1}", sensor.Name, sensor.Value.HasValue ? sensor.Value.Value.ToString() : "No Value") + " C");
                    }
                //Fan Speed
                foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Fan)
                    {
                        lstGPUValues.Items.Add(String.Format("{0} Fan = {1}", sensor.Name, sensor.Value.HasValue ? sensor.Value.Value.ToString() : "No Value") + " RPM");
                    }
                //Fan %
                foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Control)
                    {
                        lstGPUValues.Items.Add(String.Format("{0} Control = {1}", sensor.Name, sensor.Value.HasValue ? sensor.Value.Value.ToString() : "No Value") + " %");
                    }
                //GPU Clocks
                foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Clock)
                    {
                        lstGPUValues.Items.Add(String.Format("{0} Clock = {1}", sensor.Name, sensor.Value.HasValue ? sensor.Value.Value.ToString() : "No Value") + " MHz");
                    }
                //GPU Load
                foreach (var sensor in Hardware.Sensors)
                    if (sensor.SensorType == SensorType.Load)
                    {
                        lstGPUValues.Items.Add(String.Format("{0} Load = {1}", sensor.Name, sensor.Value.HasValue ? sensor.Value.Value.ToString() : "No Value") + " %");
                    }
            }
        }
    }
}   