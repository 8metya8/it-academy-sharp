using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Player
{
    public class Player
    {
        private string _producer;
        private int _ram;
        private List<Song> ListOfSongs { get; set; }

        public string Producer
        {
            get
            {
                if (_producer != null)
                {
                    return _producer;
                }
                else
                {
                    Console.WriteLine("Parametr 'Producer' is empty.");
                    return null;
                }
            }
        }

        public int Ram
        {
            set
            {
                if (CheckValueOfRam(value))
                {
                    _ram = value;
                }
                else
                {
                    Console.WriteLine("Entered value is not valid.");
                }
            }

            get
            {
                if (_ram != 0)
                {
                    return _ram;
                }
                else
                {
                    Console.WriteLine("Parametr 'Ram' is 0.");
                    return 0;
                }
            }
        }

        public Player()
        {
            _producer = "Belarus";
            ListOfSongs = new List<Song>();

            ListOfSongs.Add(new Song("Song 1", "Sting", "2015", "Pam pam trara ramp"));
            ListOfSongs.Add(new Song("Song 2", "Sting2", "2011", "Pam pam trara ramp"));
            ListOfSongs.Add(new Song("Song 3", "Sting3", "2012", "Pam pam trara ramp"));
            ListOfSongs.Add(new Song("Song 4", "Sting4", "2315", "Pam pam trara ramp"));
            ListOfSongs.Add(new Song("Song 5", "King", "1815", "Pam pam trara ramp"));

            Console.WriteLine("Player has benn created. Producer - {0}", _producer);
        }

        public Player(string producer, int ram)
        {
            _producer = producer;
            Ram = ram;
        }

        static bool CheckValueOfRam(int value)
        {           
            return (value == 16) || (value == 32) || (value == 64) || (value == 128) || (value == 256) || (value == 512);           
        }

        public void Play(string playbackOrder)
        {
            switch(playbackOrder)
            {
                case "DIRECT":
                    {
                        foreach(Song song in ListOfSongs)
                        {
                            Console.WriteLine("Now play song - {0}", song.Title);
                            Thread.Sleep(1000);
                        }

                        Console.WriteLine("All songs has been played.");
                        Console.WriteLine("-------------------------------------");
                        break;
                    }
                case "REVERSE":
                    {
                        foreach (Song song in ListOfSongs.Reverse<Song>())
                        {
                            Console.WriteLine("Now play song - {0}", song.Title);
                            Thread.Sleep(1000);
                        }

                        Console.WriteLine("All songs has been played.");
                        Console.WriteLine("-------------------------------------");
                        break;
                    }
                case "RANDOM":
                    {
                        int[] order = new int[ListOfSongs.Count];
                        bool checkUnique;

                        for(int i = 0; i < order.Length; i++)
                        {
                            checkUnique = true;

                            while (checkUnique)
                            {
                                checkUnique = false;

                                order[i] = new Random().Next(0, ListOfSongs.Count);

                                for(int n = 0; n < i; n++)
                                {
                                    if(order[i] == order[n])
                                    {
                                        checkUnique = true;
                                        break;
                                    }
                                }
                            }
                        }

                        foreach(int q in order)
                        {
                            Console.WriteLine("Now play song - {0}", ListOfSongs[q].Title);
                            Thread.Sleep(1000);
                        }

                        Console.WriteLine("All songs has been played.");
                        Console.WriteLine("-------------------------------------");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Entered incorrect word.");
                        break;
                    }
            }
        }

        public void Play(Song song)
        {
            Console.WriteLine("Now play song - {0}", song.Title);
            Thread.Sleep(1000);
            Console.WriteLine("Song has been played.");
            Console.WriteLine("-------------------------------------");
        }

        public bool Search(string title, out Song song)
        {
            foreach (Song songFromList in ListOfSongs)
            {
                if(songFromList.Title.ToUpper().Equals(title.ToUpper()))
                {
                    song = songFromList;
                    return true;
                }
            }

            song = null;
            return false;
        }
    }
}
