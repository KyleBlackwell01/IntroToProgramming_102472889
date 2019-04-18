using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Total x: ");
            int custom = int.Parse(Console.ReadLine());

            int counter = 0;
            int counter2 = 0;

            while (counter < custom)
            {
                counter2 = counter;

                while (counter2 < custom)
                {
                    Console.Write("x");
                    counter2 = counter2 + 1;
                }

                Console.WriteLine();
                counter = counter + 1;
            }

            Console.WriteLine("Goodbye");

            Console.ReadKey(true);

        }
    }
}
