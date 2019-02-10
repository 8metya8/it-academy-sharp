using System;
using System.Collections.Generic;

namespace Homework12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPlayer> players = new List<IPlayer>();

            players.Add(new Samsung(StdVoltage.V110));
            players.Add(new Sony(StdVoltage.V220));
            players.Add(new Panasonic(StdVoltage.V380));

            foreach(IPlayer player in players)
            {
                player.Start();
                player.Pause();
                player.Stop();
                (player as Power).ShowVoltage();

                Console.WriteLine(new string('-', 30));
            }

            Console.ReadKey();
        }
    }
}
