using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("Please Enter a Number:");
                var result = 1;
                for (var number = int.Parse(Console.ReadLine()); number > 1; number--)
                {
                    result *= number;
                }
                Console.WriteLine(result);

            }
            Console.ReadKey();
        }
    }
}
