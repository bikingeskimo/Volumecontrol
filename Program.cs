using System;
using System.IO.Ports;


namespace Volumecontrol
{
    class Program
    {

        
        public void setVolume(int value){
            System.Diagnostics.Process volumeProcess = new System.Diagnostics.Process();
            volumeProcess.StartInfo.FileName = "nircmd.exe";
            volumeProcess.StartInfo.Arguments = "setsysvolume " + 65535*(value/1023);
            volumeProcess.Start();
            volumeProcess.WaitForExit();
            volumeProcess.Close();

        }
        static void Main(string[] args)
        {
            Program volume = new Program();
            try{
                
                //starting and opening serial port com5
                SerialPort serialport = new SerialPort("COM5");
                System.Console.WriteLine("Connected to COM5");
                serialport.BaudRate = 9600;
                serialport.Open();
                
                
                string read = "1023";
                int oldVolume = 0;
                int newVolume;

                while(!read.Equals("0")){
                    
                    read = serialport.ReadLine();
                    
                    Int32.TryParse(read, out newVolume);
                    
                    if (!newVolume.Equals(oldVolume))
                    {
                        volume.setVolume(newVolume);
                        oldVolume = newVolume;
                        Console.WriteLine("setting volume: " + read);
                    }
                    
                }
            }catch(Exception e){
                Console.WriteLine(e);
            }
            
        }
    }
}
