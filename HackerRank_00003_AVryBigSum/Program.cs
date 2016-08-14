using System;

namespace HackerRank_00003_AVryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = new string[n];
            for (int i = 0; i < n; i++)
            {
                 arr_temp[i] = Console.ReadLine();
            }
            
            int[] arr = Array.ConvertAll(arr_temp, int.Parse);
            long soma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                soma += arr[i];
            }
            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
