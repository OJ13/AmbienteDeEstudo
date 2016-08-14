using System;

namespace HackerRank_00005_PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, int.Parse);
            int negativo = 0;
            int positivo = 0;
            int zero = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    negativo++;        //Se negativo, implementar variável
                }
                else if (arr[i] > 0)
                {
                    positivo++;        //Se positivo, implementar variável
                }
                else if (arr[i] == 0)
                {
                    zero++;        //se Zero, implementar variável
                }
            }
            //Console.WriteLine("Positivo: " + positivo +" e Negativo: " + negativo + " e Zer00s: " + zero);
            decimal resPositivo = (decimal)positivo / n;
            decimal resNegativo = (decimal)negativo / n;
            decimal resNeutro = (decimal)zero / n;

            Console.WriteLine(resPositivo + "\n" + resNegativo + "\n" + resNeutro);

            Console.ReadKey();
        }
    }
}
