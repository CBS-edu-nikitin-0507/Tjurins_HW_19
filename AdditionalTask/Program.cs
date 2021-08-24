using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDay, nextBD;
            DateTime today = DateTime.Now;

            Console.WriteLine("Enter your birthday date (dd.mm.yyyy):");
            birthDay = DateTime.Parse(Console.ReadLine());
            nextBD = new DateTime(today.Year,birthDay.Month,birthDay.Day);

            TimeSpan left = nextBD - today;
            Console.WriteLine("Until your next birthday " + left.Days + " day/s, " + left.Hours + " hours, and "+ left.Minutes + " minutes");

            Console.ReadKey();
        }

    }
}
