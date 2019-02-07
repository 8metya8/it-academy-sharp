using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class Dog : Animal
    {
        public string Breed { get; }
 
        public Dog(string kind, string breed, string name) : base(kind)
        {
            base.Name = name;
            Breed = breed;
        }

        public override void Voice()
        {
            Console.WriteLine(Name + " says gav-gav.");
        }

        public override void Move()
        {
            Console.WriteLine(Name + " runs.");
        }

        public void WagTheTail()
        {
            Console.WriteLine(Name + " wags the tail.");
        }
    }
}
