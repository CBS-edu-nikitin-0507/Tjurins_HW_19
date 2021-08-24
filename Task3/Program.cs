using System;

namespace Task3
{
    public enum Positions { HardwareTechnician = 5, Engineer = 10, BusinessAnalyst = 15, PM = 20, ITDirector = 25 }

    public class Accountant
    {
        public bool AskForBonus(Positions worker, int hours)
        {
            if (hours > ((int)worker)) return true;
            else return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            Accountant acc = new Accountant();
            Positions pos = Positions.BusinessAnalyst;

            Console.WriteLine("Enter your position number:");
            PrintAllPositions(counter);
            
            Console.Write("\nYour choice: ");
            pos = GetSelectedPosition(counter, Convert.ToInt32(Console.ReadLine()));

            Console.Write("How many hours you worked this month: ");
            int h = Convert.ToInt32(Console.ReadLine());



            if (acc.AskForBonus(pos,h)) Console.WriteLine("\nYou will get your bonus");
            else Console.WriteLine("\nGet back to work lazy bastard");

            Console.ReadKey();
        }

        public static void PrintAllPositions(int counter)
        {
            
            foreach (dynamic p in Enum.GetValues(typeof(Positions)))
            {
                Console.WriteLine(counter + " - " + p);
                counter++;
            }
        }

        public static Positions GetSelectedPosition(int counter, int x)
        {

            foreach (dynamic p in Enum.GetValues(typeof(Positions)))
            {
                if(counter == x)
                {
                    return p;
                }
                counter++;
            }

            return Positions.HardwareTechnician;

        }
    }
}
