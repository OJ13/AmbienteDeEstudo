using System;

namespace Day_07_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, int.Parse);

            for (int i = n -1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
