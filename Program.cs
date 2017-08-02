using System;
using System.IO.Ports;


namespace Volumecontrol
{
    class Program
    {

        
        public void setVolume(int value){
            System.Diagnostics.Process volumeProcess = new System.Diagnostics.Process();
            volumeProcess.StartInfo.FileName = "nircmd.exe";
            volumeProcess.StartInfo.Arguments = "setsysvolume " + (65535*(value/1023));
            volumeProcess.Start();
            volumeProcess.WaitForExit();

        }

        public string getInput(){
            try{
                
                //starting and opening serial port com5
                SerialPort serialport = new SerialPort("COM5");
                System.Console.WriteLine("Connected to COM5");
                serialport.BaudRate = 9600;
                serialport.Open();
                return serialport.ReadLine();
                serialport.Close();
            }catch(Exception e){
                Console.WriteLine(e);
                return "0";
            }
            
        }

        static void Main(string[] args)
        {
            Program volume = new Program();
            
                
                
                string read = "1023";
                int oldVolume = 1023;
                int newVolume;

                while(!read.Equals("0")){
                    read = volume.getInput();                    
                    if (Int32.TryParse(read,out newVolume))
                    {       
                        if (newVolume != oldVolume)
                        {
                            oldVolume = newVolume;
                            volume.setVolume(oldVolume);
                            Console.WriteLine("setting volume: " + read);
                        }
                    }else
                    {
                        System.Console.WriteLine("Could not parse to int");
                    }
                    
                }
            
        }
    }
}
