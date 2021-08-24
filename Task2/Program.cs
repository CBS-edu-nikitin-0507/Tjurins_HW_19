using System;

namespace Task2
{
    public enum Colors
    {
        Red = 1, Blue, Green
    }
    public static class Line
    {
        public static void PrintLine(string stroka, int color)
        {
            Console.WriteLine("\nYour line:");
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
            Console.WriteLine(stroka);
            Console.ResetColor();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of color which you would like to use for printing:");

            foreach (dynamic color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(((int)color) + " - " + color);
            }

            Console.Write("Your choice:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter your line:");
            Line.PrintLine(Console.ReadLine(), x);

            Console.ReadKey();
        }
    }
}
