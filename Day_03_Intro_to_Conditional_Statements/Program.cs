using System;

namespace Day_03_Intro_to_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1)
                Console.WriteLine("Weird");
            else if (N >= 2 && N <= 5)
                Console.WriteLine("Not Weird");
            else if (N >= 6 && N <= 20)
                Console.WriteLine("Weird");
            else if (N > 20)
                Console.WriteLine("Not Weird");

            Console.ReadKey();
        }
    }
}
