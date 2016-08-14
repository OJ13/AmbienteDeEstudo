using System;

namespace HackerRank_00001
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);

            Console.WriteLine(sum);

            Console.ReadKey();
        }

        static int solveMeFirst(int a, int b)
        {
            return a + b;
        }
    }
}
