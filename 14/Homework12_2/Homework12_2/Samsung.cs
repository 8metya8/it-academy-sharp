using System;

namespace Homework12_2
{
    public class Samsung : Power, IPlayer
    {
        public Samsung(StdVoltage voltage)
                        : base(voltage)
        {

        }

        public override void ShowVoltage()
        {
            Console.WriteLine("Samsung Voltage = {0}", Voltage);
        }

        public void Pause()
        {
            Console.WriteLine("Samsung - Pause()");
        }

        public void Start()
        {
            Console.WriteLine("Samsung - Start()");
        }

        public void Stop()
        {
            Console.WriteLine("Samsung - Stop()");
        }
    }
}
