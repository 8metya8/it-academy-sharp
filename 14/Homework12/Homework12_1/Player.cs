using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_1
{
    public class Player : IRecodable, IPlayable
    {
        public void Record()
        {
            Console.WriteLine("Start Record.");
        }

        public void Play()
        {
            Console.WriteLine("Start Play.");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop Record.");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop Play.");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause Record.");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause Play.");
        }
    }
}
