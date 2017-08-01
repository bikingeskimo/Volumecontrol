import subprocess
import time
import serial

ser = serial.Serial(
        port='COM5',
        baudrate = 9600,
        parity=serial.PARITY_NONE,
        stopbits=serial.STOPBITS_ONE,
        bytesize=serial.EIGHTBITS,
        timeout=None
)

while True:
    potString = ser.readline()
    print("Pot: " + potString)
# command = "nircmd setsysvolume " + str(65535*(float(potString)/1023))
    process = subprocess.Popen(["nircmd","setsysvolume",str(65535*(float(potString)/1023))]).wait()