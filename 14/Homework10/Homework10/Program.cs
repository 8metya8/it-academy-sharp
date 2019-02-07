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
            Animal animal = new Animal("base animal", 5);
            Dog dog = new Dog("dog", "buldog", "Tuzik");
            Dog dog2 = new Dog("dog", "shpitz", "Micro");
            Animal baseDog;

            dog.Age = 10;
            dog.Weight = 25;
            dog2.Weight = 5;
            dog.Age = 5;
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

            Console.WriteLine("Calling Dog class method by Animal class link:");
            baseDog.Voice();
            baseDog.Move();
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Overload operators:");
            Console.WriteLine("operator ++, 'animal' before {0}, after {1}",animal.Weight, (animal++).Weight);
            Console.WriteLine("operator *, animal * 3, 'animal' before {0}, after {1}", animal.Weight, (animal *= 2).Weight);
            Console.WriteLine("operator -, (dog1 - dog2) = {0}", dog - dog2);

            Console.ReadKey();
        }
    }
}
