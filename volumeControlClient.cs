using System;
using System.IO.Ports;


namespace Volumecontrol
{
    class volumeControlClient
    {
        int maxVolume = 65535;
        string controllerNumber;

        public volumeControlClient(string controllerNumber){
            this.controllerNumber = controllerNumber;
        }

        //adjusting volume up or down by 65535(max)/number of buttonpresses needed to go from 0-100
        public void setApplicationVolume(string value, double steps, string applicationName, bool focused = false){
            System.Diagnostics.Process volumeProcess = new System.Diagnostics.Process();
            volumeProcess.StartInfo.FileName = "nircmd.exe";
            if (value.Equals(controllerNumber))
            {
                volumeProcess.StartInfo.Arguments = ("changeappvolume " + applicationName + " " + 1/steps).ToString();
                System.Console.WriteLine("Appvolume changed " + 1/steps);
                volumeProcess.Start();
                volumeProcess.WaitForExit();

            }
            if (value.Equals("-" + controllerNumber))
            {
                volumeProcess.StartInfo.Arguments = ("changeappvolume " + applicationName + " " + -1/steps).ToString();
                System.Console.WriteLine("Appvolume changed " + -1/steps);
                volumeProcess.Start();
                volumeProcess.WaitForExit();
            }
        }
        public void setVolume(string value, int steps)
        {
            System.Diagnostics.Process volumeProcess = new System.Diagnostics.Process();
            volumeProcess.StartInfo.FileName = "nircmd.exe";
            if (value.Equals("1"))
            {
                volumeProcess.StartInfo.Arguments = ("changesysvolume " + maxVolume / steps).ToString();
                System.Console.WriteLine("Volumchange " + maxVolume / steps);
                volumeProcess.Start();
                volumeProcess.WaitForExit();

            }
            if (value.Equals("-1"))
            {
                volumeProcess.StartInfo.Arguments = ("changesysvolume " + -maxVolume / steps).ToString();
                System.Console.WriteLine("Volumchange " + -maxVolume / steps);
                volumeProcess.Start();
                volumeProcess.WaitForExit();
            }

        }

        public SerialPort connectSerial(string portName)
        {
            //starting and opening serial port
            try
            {
                SerialPort serialport = new SerialPort(portName);
                System.Console.WriteLine("Connected to: " + portName);
                serialport.BaudRate = 9600;
                serialport.Open();
                return serialport;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return null;
            }
        }

        public string getInput(SerialPort serialport)
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
            volumeControlClient volume = new volumeControlClient("1");
            SerialPort sp = volume.connectSerial("COM5");
            while (true)
            {
                //volume.setVolume(volume.getInput(sp), 20);
                volume.setApplicationVolume(volume.getInput(sp), 5,"spotify.exe");
            }
        }
    }
}
