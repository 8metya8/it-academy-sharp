using System;

namespace Homework12_2
{
    public class Sony : Power, IPlayer
    {
        public Sony(StdVoltage voltage)
                   : base(voltage)
        {

        }

        public void Pause()
        {
            Console.WriteLine("Sony - Pause()");
        }

        public void Start()
        {
            Console.WriteLine("Sony - Start()");
        }

        public void Stop()
        {
            Console.WriteLine("Sony - Stop()");
        }
    }
}
