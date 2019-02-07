using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06_1
{
    class Homework06_1
    {
        static void Main(string[] args)
        {
            Stack test = new Stack();

            for (int i = 0; i < 15; i++)
            {
                test.Push(i);
            }

            Console.WriteLine("Count {0}, IsEmpty - {1}", test.Count, test.IsEmpty);

            Console.Write(" {0} ", test.Peek());
            Console.WriteLine("Count {0}, IsEmpty - {1}", test.Count, test.IsEmpty);

            for (int i = 0; i < 15; i++)
            {
                Console.Write(" {0} ", test.Pop());
            }

            Console.WriteLine("Count {0}, IsEmpty - {1}", test.Count, test.IsEmpty);

            Stack testSize = new Stack(15);

            for (int i = 0; i < 15; i++)
            {
                testSize.Push(i);
            }

            Console.WriteLine("Count {0}, IsEmpty - {1}", testSize.Count, testSize.IsEmpty);

            Console.Write(" {0} ", testSize.Peek());
            Console.WriteLine("Count {0}, IsEmpty - {1}", testSize.Count, testSize.IsEmpty);

            for (int i = 0; i < 15; i++)
            {
                Console.Write(" {0} ", testSize.Pop());
            }

            Console.WriteLine("Count {0}, IsEmpty - {1}", testSize.Count, testSize.IsEmpty);

            Console.ReadKey();
        }
    }
}
