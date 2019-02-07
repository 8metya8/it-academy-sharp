using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("base animal");
            Dog dog = new Dog("dog", "buldog", "Tuzik");
            Animal baseDog;

            dog.Age = 10;
            dog.Weight = 25;
            baseDog = dog;

            Console.WriteLine("Methods of base class:");
            animal.Voice();
            animal.Move();
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Methods of Dog class:");
            dog.Voice();
            dog.Move();
            dog.WagTheTail();
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Calling Dog class method by Animal class object:");
            baseDog.Voice();
            baseDog.Move();
            Console.WriteLine(new string('-', 20));

            Console.ReadKey();
        }
    }
}
