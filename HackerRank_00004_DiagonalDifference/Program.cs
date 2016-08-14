using System;

namespace HackerRank_00004_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, int.Parse);
            }
            int somad1 = 0;
            int aux = 1;
            int somad2 = 0;
            for (int i = 0; i < n; i++)
            {
                somad1 += a[i][i];
            }            
            for (int i = 0; i < n; i++)
            {
               somad2 += a[i][n - aux];
                aux++;                
            }
            int resultado = (somad1 - somad2);
            if (resultado < 0)
                resultado = resultado * -1;

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
