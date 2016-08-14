using System;

namespace Day_06_Lets_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = new string[n];
            string[] impar = new string[n];
            string[] par = new string[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
                var p = s[i].ToCharArray();
                for (int j = 0; j < s[i].Length; j++)
                {
                    if (j%2 == 0)
                    {
                        impar[i] += p[j];
                    }
                    else
                    {
                        par[i] += p[j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(impar[i] + " " + par[i]);
            }
            Console.ReadKey();
        }
    }
}
