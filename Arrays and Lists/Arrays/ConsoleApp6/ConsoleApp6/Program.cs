using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int count = 0;

            int[] scorearray = new int[20];


            
            while(count < 20)
            {
                Console.Write("Input Score:  ");
                int score = int.Parse(Console.ReadLine());
                scorearray[count] = score;
                total += score;
                count++;
            }

            int avg = total / 20;

            Console.WriteLine("Total Average: " + avg);


            Console.ReadKey();
        }
    }
}
