using System;

namespace DragonHatcherySimulator
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Dragon Hatchery Simulator!");

            // Gets the user input for the num of dragons
            Console.Write("Enter the inintial number of dragons: ");
            int initialDragons = int.Parse(Console.ReadLine());

            Console.Write("Enter the daily growth rate(Percentage): ");
            double growthRatePerc = double.Parse(Console.ReadLine());
            double growthRate = growthRatePerc / 100.0;

            Console.Write("Enter the number of weeks: ");
            int weeks = int.Parse(Console.ReadLine());
            int days = weeks * 7;

            double total = initialDragons * Math.Pow(1 + growthRate, days);
            int roundTotal = (int)Math.Round(total);

            Console.WriteLine($"\nAfter {days} days, there will be approximately {roundTotal} dragons in the hatchery.");

        }
    }
}