using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {

            string kindOfPlayback;
            string decide;
            bool run = true;
            Player player = new Player();
            player.Ram = 128;


            Console.WriteLine("Pproducer - {0}, Ram - {1} Gb.", player.Producer, player.Ram);

            while(run)
            {
                Console.WriteLine("Are you want to play all playlist or look for one song and play it? Enter you choice - play/find. For Exit enter - exit.");

                decide = Console.ReadLine().ToString().ToUpper();

                switch (decide)
                {
                    case "PLAY":
                        {
                            Console.WriteLine("Choose kind of playback - direct/reverse/random. Enter your choice.");

                            kindOfPlayback = Console.ReadLine().ToString().ToUpper();

                            player.Play(kindOfPlayback);
                            break;
                        }

                    case "FIND":
                        {
                            string title;
                            bool play;
                            Song song;

                            Console.WriteLine("Enter title of song:");

                            title = Console.ReadLine().ToString();
                            
                            if(player.Search(title, out song))
                            {
                                Console.WriteLine("Song {0} has been found", title);
                                Console.WriteLine("Do you want to plat this song? Yes/No");

                                play = Console.ReadLine().ToString().ToUpper().Equals("YES");

                                if (play)
                                {
                                    player.Play(song);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Song {0}  not found", title);
                                Console.WriteLine("-------------------------------------");
                            }
                            break;
                        }

                    case "EXIT":
                        {
                            run = false;
                            break;
                        }
                }
            }
        }
    }
}
