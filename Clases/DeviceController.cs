using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace CAN_Switch_GUI.Clases
{
    enum SwitchStates
    {
        Disconnect,
        Rack1,
        Rack2,
        Rack3,
    }

    internal class DeviceController
    {
        private LogController logController;
        private RadioButtonController radioButtonController;
        private string deviceId;
        private SerialPort ArduinoPort;
        private int numberOfRacks;

        private int defaultNumberOfRacks = 3;

        public DeviceController(LogController logController, RadioButtonController radioButtonController) 
        {
            this.logController = logController;
            this.radioButtonController = radioButtonController;

            this.deviceId = AutodetectArduinoPort();

            this.ArduinoPort = StartCommunication(deviceId);

            this.numberOfRacks = GetNumberOfRacks();

            radioButtonController.SetRadioButtonsNumber(numberOfRacks);
        }
        
        // 
        public void ChangeSelection(SwitchStates targetState)
        {
            switch (targetState)
            {
                case SwitchStates.Disconnect:
                    logController.ShowLogText("CAN disconnected");
                    Console.WriteLine("Disconnect");
                    break;
                case SwitchStates.Rack1:
                    logController.ShowLogText("CAN of Rack 1 connected");
                    Console.WriteLine("Rack 1");
                    break;
                case SwitchStates.Rack2:
                    logController.ShowLogText("CAN of Rack 2 connected");
                    Console.WriteLine("Rack 2");
                    break;
                case SwitchStates.Rack3:
                    logController.ShowLogText("CAN of Rack 3 connected");
                    Console.WriteLine("Rack 3");
                    break;
            }
        }

        // Comunication
        public SerialPort StartCommunication(string deviceId)
        {
            // If there is a port open it
            if (deviceId != string.Empty)
            {
                //crear Serial Port
                ArduinoPort = new SerialPort();
                ArduinoPort.PortName = deviceId;  //sustituir por vuestro 
                ArduinoPort.BaudRate = 9600;
                ArduinoPort.Open();
            }


            logController.ShowLogText("Connected to: " + deviceId);

            return ArduinoPort;
        }

        public int GetNumberOfRacks()
        {
            return defaultNumberOfRacks;
        }

        public void StopCommunication()
        {
            ArduinoPort?.Close();
        }

        public string AutodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    if (desc != null && deviceId != null && desc.Contains("Arduino"))
                    {
                        logController.ShowLogText("Detected: " + deviceId);
                        return deviceId;
                    }
                }
            }
            catch (ManagementException e)
            {
                logController.ShowLogText(e.ToString());
            }

            logController.ShowLogText("No Arduino detected");

            return String.Empty;
        }
    }
}
