using System;

namespace Day_03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = Convert.ToDouble(Console.ReadLine());
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            int taxPercent = Convert.ToInt32(Console.ReadLine());

            double tip = mealCost * tipPercent / 100;
            double tax = mealCost * taxPercent / 100;
            double totalCost = mealCost + tip + tax;

            Console.WriteLine("The total meal cost is " + (string.Format("{0:0}",totalCost)) + " dollars.");

            Console.ReadKey();
        }
    }
}
