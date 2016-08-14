using System;
namespace Day_11_2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, int.Parse);
            }
            for (int movBaixo = 0; movBaixo < arr.Length; movBaixo++)               //Eixo X
            {
                for (int movDir = 0; movDir < arr.Length; movDir++)                 //Eixo Y
                {
                    for (int x = 0; x < 3; x++) //Para Descer na Ampulheta
                    {
                        if (movDir == (arr.Length - 3))
                        {

                        }
                        if (x == 1)
                        {
                            for (int y = movDir+1 ; y <= movDir+1; y++)     //Para gerar e a direita a ampulheta(centro da ampulheta)
                            {
                                Console.Write("\n");
                                Console.WriteLine(arr[x][y]);
                            }
                        }
                        else
                        {
                            for (int y = movDir; y < movDir+3; y++)        //Para gerar e a direita a ampulheta(resto da ampulheta)
                            {
                                Console.Write(arr[x][y]);
                            }
                        }
                    }
                    Console.WriteLine("\n-----");
                }
            }
            Console.ReadKey();
        }
    }
}
