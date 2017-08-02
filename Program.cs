using System;
using System.IO.Ports;


namespace Volumecontrol
{
    class Program
    {
        int maxVolume = 65535;

        
        //adjusting volume up or down by 65535(max)/number of buttonpresses needed to go from 0-100
        public void setVolume(string value,int steps){
            System.Diagnostics.Process volumeProcess = new System.Diagnostics.Process();
            volumeProcess.StartInfo.FileName = "nircmd.exe";
            if(value.Equals("1")){
                volumeProcess.StartInfo.Arguments = ("changesysvolume " + maxVolume/steps).ToString();
                System.Console.WriteLine("Volumchange " + maxVolume/steps);
                volumeProcess.Start();
                volumeProcess.WaitForExit();
                                
            }
            if(value.Equals("-1")){
                volumeProcess.StartInfo.Arguments = ("changesysvolume " + -maxVolume/steps).ToString();
                System.Console.WriteLine("Volumchange " + -maxVolume/steps);
                volumeProcess.Start();
                volumeProcess.WaitForExit();
            }

        }

        public SerialPort connectSerial(string portName){
                //starting and opening serial port
            try{
                SerialPort serialport = new SerialPort(portName);
                System.Console.WriteLine("Connected to: " + portName);
                serialport.BaudRate = 9600;
                serialport.Open();
                return serialport;
            }catch(Exception e){
                System.Console.WriteLine(e);
                return null;
            }
        }

        public string getInput(SerialPort serialport){
            try{
                string output = serialport.ReadLine();
                return output;
            }catch(Exception e){
                Console.WriteLine(e);
                return "0";
            }
            
        }

        static void Main(string[] args)
        {
            Program volume = new Program();
            SerialPort sp = volume.connectSerial("COM5");
            while(true){
                volume.setVolume(volume.getInput(sp),20);
            }
        }
    }
}
