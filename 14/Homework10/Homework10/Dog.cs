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
 
        public Dog()
        {
            base.Name = "Default name";
        }

        public Dog(string kind, string breed, string name) : base(kind, 10.0)
        {
            base.Name = name;
            Breed = breed;
        }

        public static double operator - (Dog dog1, Dog dog2)
        {
            return dog1.Weight - dog2.Weight;
        }

        //Этот метод запретим переопределять при наследовании от класса Dog
        sealed public override void Voice()
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
