using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05_1
{
    class Homework05_1
    {
        static void Main(string[] args)
        {
            int[] massive = new int[6] { 55, 20, 12, 8, 15, 21};

            Console.WriteLine("Max element - {0}", MaxElement(massive));
            Console.WriteLine("Min element - {0}", MinElement(massive));
            Console.WriteLine("Sum all element - {0}", SumAllElement(massive));
            Console.WriteLine("Average - {0}", Average(massive));
            Console.WriteLine("Odd numbers: ");
            PrintOddNumbers(massive);

            Console.ReadKey();
        }

        public static int MaxElement(int[] mas)
        {
            if(mas != null && mas.Length > 0)
            {
                int max = mas[0];

                for(int i = 1; i < mas.Length; i++)
                {
                    if(mas[i] > max)
                    {
                        max = mas[i];
                    }
                }

                return max;
            }
            else
            {
                Console.WriteLine("Massiv is empty or null.");

                return 0;
            }
            
        }

        public static int MinElement(int[] mas)
        {
            if (mas != null && mas.Length > 0)
            {
                int min = mas[0];

                for (int i = 1; i < mas.Length; i++)
                {
                    if (mas[i] < min)
                    {
                        min = mas[i];
                    }
                }

                return min;
            }
            else
            {
                Console.WriteLine("Massiv is empty or null.");

                return 0;
            }
        }

        public static int SumAllElement(int[] mas)
        {
            if (mas != null && mas.Length > 0)
            {
                int sum = 0;

                for (int i = 0; i < mas.Length; i++)
                {
                    sum += mas[i];
                }

                return sum;
            }
            else
            {
                Console.WriteLine("Massiv is empty or null.");

                return 0;
            }
        }

        public static double Average(int[] mas)
        {
            if (mas != null && mas.Length > 0)
            {
                double sum = 0;

                for (int i = 0; i < mas.Length; i++)
                {
                    sum += mas[i];
                }

                double avg = Math.Round(sum / mas.Length, 2);

                return avg;
            }
            else
            {
                Console.WriteLine("Massiv is empty or null.");

                return 0;
            }
        }

        public static void PrintOddNumbers(int[] mas)
        {
            if (mas != null && mas.Length > 0)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if(mas[i] % 2 != 0)
                    {
                        Console.Write(" {0} ", mas[i]);
                    }
                }

            }
            else
            {
                Console.WriteLine("Massiv is empty or null.");
            }
        }
    }
}
