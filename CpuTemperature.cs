using System;
using System.IO;

namespace RPi.Sensors.Devices.Cpu
{
    public class Cpu
    {
        public double? GetTemperature()
        {
            using (FileStream fileStream = new FileStream("/sys/class/thermal/thermal_zone0/temp", FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string data = reader.ReadLine();
                int temperature;
                if (int.TryParse(data, out temperature))
                {
                    return Math.Round(temperature / 1000F, 1);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
