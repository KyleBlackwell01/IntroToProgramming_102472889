using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[10];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Insert Name: ");
                names[i] = Console.ReadLine();
                Console.Clear();
            }
            foreach (string s in names)
                Console.WriteLine("Hello " + s);

            Console.ReadLine();

            Console.ReadKey();

        }
    }
}
