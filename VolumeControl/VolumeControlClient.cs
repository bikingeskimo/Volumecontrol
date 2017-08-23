using System;
using System.IO.Ports;

namespace Volumecontrol
{
    class volumeControlClient
    {
        int maxVolume = 65535;
        string controllerNumber;
        SerialPort serialport;

        public volumeControlClient(string controllerNumber, SerialPort serialport)
        {
            this.controllerNumber = controllerNumber;
            System.Console.WriteLine(controllerNumber);
            this.serialport = serialport;
        }


        public void startProcess(string input, string command, double steps = 0, string applicationName = "", bool focused = false)
        {
            if (input.Contains(controllerNumber))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "nircmd.exe";

                try
                {
                    int value;

                    if (Int32.TryParse(input, out value) && value < 0)
                    {
                        steps = -steps;
                    }
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                }
                string focusedString = "";
                //check if volume should go up or down (up is positive change up, and negative is steps down)

                if (focused == true)
                {
                    focusedString = "focused";
                }

                process.StartInfo.Arguments = (command + " " + applicationName + steps + " " + focusedString).ToString();
                process.Start();
                process.WaitForExit();
            }

        }

        public void changeApplicationVolume(string input, double steps, string applicationName = "", bool focused = false)
        {

            steps = 1 / steps;
            startProcess(input, "changeappvolume ", steps, applicationName + " ", focused);
            System.Console.WriteLine("Changed application volume: " + steps);

        }

        public void changeSystemVolume(string input, int steps)
        {

            steps = maxVolume / steps;
            startProcess(input, "changesysvolume", steps);
            System.Console.WriteLine("Changed system volume: " + steps);

        }

        public void muteSystemVolume(string input)
        {
            startProcess(input, "mutesysvolume 2");
            System.Console.WriteLine("muting system audio");
        }

        public void muteApplicationVolume(string input, string applicationName)
        {
            startProcess(input, "muteappvolume", 0, applicationName, true);
            System.Console.WriteLine("muting application");
        }

        //Connect to serialport 
        public SerialPort connectSerial(string portName)
        {
            //starting and opening serial port
            try
            {
                SerialPort serialport = new SerialPort(portName);
                serialport.BaudRate = 115200;
                serialport.Open();
                System.Console.WriteLine("Connected to: " + portName);
                return serialport;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return null;
            }

        }

        public string readInput(SerialPort serialport)
        {
            //reading string from serial and returning it
            try
            {
                string output = serialport.ReadLine();
                return output;
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }

        static void Main(string[] args)
        {
            try
            {
                SerialPort serialport = new SerialPort("COM6", 115200);
                serialport.Open();
                volumeControlClient volume = new volumeControlClient("1", serialport);
                volumeControlClient vol2 = new volumeControlClient("2", serialport);

                string input;

                while (true)
                {
                    input = serialport.ReadLine();
                    System.Console.WriteLine("Input: " + input);
                    volume.changeApplicationVolume(input, 10, "chrome.exe");
                    vol2.changeSystemVolume(input, 10);
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }




        }
    }
}
