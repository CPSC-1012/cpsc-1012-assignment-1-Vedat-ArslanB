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
            int inintialDragons = int.Parse(Console.ReadLine());

            Console.Write("Enter the daily growth rate(Percentage): ");
            double growthRatePerc = double.Parse(Console.ReadLine());
            double growthRate = growthRatePerc / 100.0;

        }
    }
}