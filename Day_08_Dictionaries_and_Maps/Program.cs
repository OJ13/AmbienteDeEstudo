using System;
using System.Collections;

namespace Day_08_Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de Telefones Adicionados:");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Hashtable phonebook = new Hashtable();
            string[] arr_temp = new string[numbers];
            for (int i = 0; i < numbers; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                phonebook.Add(arr[0], arr[1]);
            }
            for (int i = 0; i < numbers; i++)
            {
                arr_temp[i] = Console.ReadLine();
            }
            for (int i = 0; i < numbers; i++)
            {
                if (phonebook.ContainsKey(arr_temp[i].ToString()))
                {
                    string nome = arr_temp[i].ToString();
                    string number = (string)phonebook[arr_temp[i].ToString()];

                    Console.WriteLine("{0}={1}", nome, number);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            //foreach (DictionaryEntry item in phonebook)
            //{
            //    string nome = (string)item.Key;
            //    string number = (string)item.Value;

            //    Console.WriteLine("{0}={1}", nome, number);
            //}
            Console.ReadKey();
        }
    }
}
