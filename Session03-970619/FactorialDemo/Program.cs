using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number:");
            var number = int.Parse(Console.ReadLine());
            int result = 1;

            while (number > 0)
            {
                //result = result * number;
                result *= number;
                //number = number - 1;
                //number -= 1;
                number--;
                //--number;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
