using System;

namespace Day_05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(N + " X " + i + " = " + N*i);
            }

            Console.ReadKey();
        }
    }
}
