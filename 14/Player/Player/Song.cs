using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Song
    {
        public string Title { get; }
        public string Author { get; }
        public string YearOfIssue { get; }
        public string TextOfSong { get; }

        public Song(string title, string author, string year, string text)
        {
            Title = title;
            Author = author;
            YearOfIssue = year;
            TextOfSong = text;
        }
    }
}
