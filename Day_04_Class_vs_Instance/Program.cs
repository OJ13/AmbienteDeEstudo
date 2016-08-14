using System;

namespace Day_04_Class_vs_Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[qtd];
            for (int i = 0; i < qtd; i++)
            {
                arr[i]  = Convert.ToInt32(Console.ReadLine());                
            }
            for (int i = 0; i < qtd; i++)
            {
                Person pessoa = new Person(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
