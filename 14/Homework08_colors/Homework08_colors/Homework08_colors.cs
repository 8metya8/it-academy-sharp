using System;

namespace Homework08_colors
{
    class Homework08_colors
    {
        static void Main(string[] args)
        {
            int color;
            string strForPrint;

            Console.WriteLine("Enter string for print:");
            strForPrint = Console.ReadLine().ToString();

            if(strForPrint != null && strForPrint != "")
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Following colors are avaliable:");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} - {1}", i, (Color)i);
                }

                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Enter your color (number):");

                if(Int32.TryParse(Console.ReadLine(), out color) && (color > 0 && color <= 10))
                {
                    ColoredPrint.Print(strForPrint, color);
                }
                else
                {
                    Console.WriteLine("You has entered incorect number of color!");
                }
            }
            else
            {
                Console.WriteLine("You has entered empty string!");
            }

            Console.WriteLine("For exit press any key.");
            Console.ReadKey();
        }
    }

    enum Color
    {
        DarkBlue = 1,
        DarkGreen = 2,
        DarkCyan = 3,
        DarkRed = 4,
        DarkMagenta = 5,
        DarkYellow = 6,
        Gray = 7,
        DarkGray = 8,
        Blue = 9,
        Green = 10
    }

    static class ColoredPrint
    {
        public static void Print(string stroka, int color)
        {
            Console.WriteLine(new string('*', 30));
            Console.Write("You has choosed ");
            Console.ForegroundColor = (ConsoleColor)color;
            Console.Write((ConsoleColor)color);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" color.");
            Console.WriteLine(new string('*', 30));
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(new string('*', 30));
        }
    }
}
