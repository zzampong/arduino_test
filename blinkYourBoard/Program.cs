using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using LattePanda.Firmata;
namespace blinkYourBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Arduino arduino = new Arduino();
            arduino.pinMode(13, Arduino.OUTPUT);//Set the digital pin 13 as output           
            while (true)
            {
                // ==== set the led on or off  
                arduino.digitalWrite(13, Arduino.HIGH);//set the LED　on  
                Thread.Sleep(1000);//delay a seconds  
                arduino.digitalWrite(13, Arduino.LOW);//set the LED　off  
                Thread.Sleep(1000);//delay a seconds  
            }
        } 
    }
}