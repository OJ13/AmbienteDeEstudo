using System;

namespace HackerRank_00006_StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[,] arr = new string[n,n];
            int aux = n;
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    while (aux <= i)
            //    {
            //        arr[i, aux] += "X";
            //        Console.Write(arr[i, aux]);
            //        aux++;
            //    }
            //    aux = 0;
            //    Console.Write("\n");
            //}
            int a = 0;
            int b = n - 2;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    if (i <= a && j <= b) 
                    {
                        arr[i, j] += " ";
                        Console.Write(arr[i, j]);
                    }
                    else { 
                    arr[i, j] += "#";
                    Console.Write(arr[i, j]);
                    }
                }
                a++;
                b--;                   
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
