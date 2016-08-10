using System;

namespace Day_01_Hello_World
{
    class Solution
    {
        static void Main(string[] args)
        {
            String inputString; // declare a variable to hold our input
            inputString = Console.ReadLine(); // get a line of input from stdin and save it to our variable

            // Your first line of output goes here
            Console.WriteLine("Hello, World.");

            // Write the second line of output
            Console.Write(inputString);
        }
    }
}
