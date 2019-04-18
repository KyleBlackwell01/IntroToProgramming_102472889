using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTask3
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();


            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result;


            result = p.AddTwoNumbers(num1, num2);

            Console.WriteLine(result);

            Console.ReadKey();

            
            
        }

        public int AddTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        
    }
}
