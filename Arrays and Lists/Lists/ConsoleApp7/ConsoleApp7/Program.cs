using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            List<int> numbers = new List<int>();


            while (count < 5)
            {
                Console.Write("Input a number: ");
                numbers.Add(int.Parse(Console.ReadLine()));
                count++;
            }

            Console.Write("Please input another number: ");
            if (numbers.Contains(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("Number Already Exists.");
            }

            Console.ReadKey();
           

        }
    }
}
