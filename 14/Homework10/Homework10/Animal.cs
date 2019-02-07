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
        public string Kind { get; }
        private double weight;
        private int age;

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value > 0 ? value : 0;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value > 0 ? value : 0;
            }
        }

        public Animal()
        {
            Kind = "Default animal";
            Weight = 0;
        }

        public Animal(string kind, double weight)
        {
            Kind = kind;
            Weight = weight;
        }

        public static Animal operator ++ (Animal animal)
        {
            animal.Weight++;

            return animal;
        }
        
        public static Animal operator * (Animal animal, int n)
        {
            animal.Weight *= n;

            return animal;
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
