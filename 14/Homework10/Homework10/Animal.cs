using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Animal
    {
        public string Name { get; set; }
        public int  Age { get; set; }
        public double Weight { get; set; }
        public string Kind { get; set; }

        public Animal(string kind)
        {
            Kind = kind;
        }

        public virtual void Voice()
        {
            Console.WriteLine(Kind + " doesn't have voice.");
        }

        public virtual void Move()
        {
            Console.WriteLine(Kind + " can't move.");
        }
    }
}
