using System;

namespace Homework12_2
{
    public class Panasonic : Power,IPlayer
    {
        public Panasonic(StdVoltage voltage)
                        : base(voltage)
        {

        }

        public override void ShowVoltage()
        {
            Console.WriteLine("Panasonic Voltage = {0}", Voltage);
        }

        public void Pause()
        {
            Console.WriteLine("Panasonic - Pause()");
        }

        public void Start()
        {
            Console.WriteLine("Panasonic - Start()");
        }

        public void Stop()
        {
            Console.WriteLine("Panasonic - Stop()");
        }
    }
}
