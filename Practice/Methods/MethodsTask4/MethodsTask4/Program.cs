using System;

namespace MethodsTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            swapInteger(ref num1, ref num2);



            Console.WriteLine(num1 + " " + num2);


            Console.ReadKey();
        }

        static void swapInteger(ref int num1, ref int num2)
        {

           if (num1 != num2)
            {
                num1 ^= num2;
                num2 ^= num1;
                num1 ^= num2;

            }
           
        }
    }
}
