using System;

namespace Day_10_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //string aux = "";
            int x, y = 0, c1 = 0;
            //int consecutive_1 = 0;
            do
            {
                //aux += Convert.ToString(n % 2);
                x = n % 2;
                n = n / 2;

                if (x == 1)
                {
                    c1++;
                    if (c1 >= y)
                    {
                        y = c1;
                    }
                }
                else
                {
                    c1 = 0;
                }

            } while (n >= 1);

            //aux.ToCharArray();

            //for (int i = 0; i < aux.Length; i++)
            //{
            //    if (aux[i] == '1')
            //    {
            //        consecutive_1++;
            //        if (consecutive_1 >= c1)
            //        {
            //            consecutive_1 = c1;
            //        }
            //    }
            //    else if (aux[i] == '0')
            //    {
            //        consecutive_1 = 0;
            //    }
            //}
            //Console.WriteLine(aux);
            //Console.WriteLine(consecutive_1);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
