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
        private ComboBox cmbBox_DeviceList;
        private string[] deviceList;
        private SerialPort ArduinoPort;
        private int numberOfRacks;


        private int defaultNumberOfRacks = 3;

        public DeviceController(LogController logController, RadioButtonController radioButtonController, ComboBox cmbBox_DeviceList) 
        {
            this.logController = logController;
            this.radioButtonController = radioButtonController;
            this.cmbBox_DeviceList = cmbBox_DeviceList;

            this.deviceList = AutodetectArduinoPort();

            this.ArduinoPort = StartCommunication(deviceList);

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
                    ArduinoPort.Write("deactivateRelays\n");
                    break;
                case SwitchStates.Rack1:
                    logController.ShowLogText("CAN of Rack 1 connected");
                    Console.WriteLine("Rack 1");
                    ArduinoPort.Write("activeRelay1\n");
                    break;
                case SwitchStates.Rack2:
                    logController.ShowLogText("CAN of Rack 2 connected");
                    Console.WriteLine("Rack 2");
                    ArduinoPort.Write("activeRelay2\n");
                    break;
                case SwitchStates.Rack3:
                    logController.ShowLogText("CAN of Rack 3 connected");
                    Console.WriteLine("Rack 3");
                    ArduinoPort.Write("activeRelay3\n");
                    break;
            }
        }

        // Comunication
        public SerialPort StartCommunication(string[] deviceList)
        {
            if (deviceList.Length == 1)
            {
                cmbBox_DeviceList.SelectedIndex = 0;

                //crear Serial Port
                StablishSerialComunication(deviceList[0]);

                logController.ShowLogText("Connected to: " + ArduinoPort.PortName);
            }
            else if (deviceList.Length >= 1)
            {
                ArduinoPort.ReadLine();
            }

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

        public string[] AutodetectArduinoPort()
        {
            var ports = SerialPort.GetPortNames();

            foreach (var port in ports)
            {
                cmbBox_DeviceList.Items.Add(port);
            }

            return ports;
        }

        private bool StablishSerialComunication(string port)
        {
            //crear Serial Port
            ArduinoPort = new SerialPort();
            ArduinoPort.PortName = port;  //sustituir por deviceId vuestro 
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            return true;
        }
    }
}
