# RPi.CpuTemperature.NET.Standard

example to calibrate Pi Sense HAT on a Raspberry Pi 3+

```C#
Cpu cpu = new Cpu();
double temp_calibrated;
double temperatureValue = 38;

double? cpu_temp = cpu.GetTemperature();
if (cpu_temp != null)
{
    temp_calibrated = temperatureValue - (((double)cpu_temp - temperatureValue) / 0.79);
}
else
{
    temp_calibrated = temperatureValue;
}
```
