using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number:");
            var number = int.Parse(Console.ReadLine());
            int result = 1;

            do
            {
                result *= number;
            } while (--number > 0);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
