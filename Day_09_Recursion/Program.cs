using System;

namespace Day_09_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro Positivo:");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Factorial(x));
            Console.ReadKey();
            
        }
        public static int Factorial(int x)
        {
            if (x <= 1)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
