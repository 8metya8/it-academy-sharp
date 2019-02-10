using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.Play();
            (player as IPlayable).Pause();
            player.Play();
            (player as IPlayable).Stop();

            Console.WriteLine(new string('-', 25));

            player.Record();
            (player as IRecodable).Pause();
            player.Record();
            (player as IRecodable).Stop();

            Console.ReadKey();
        }
    }
}
