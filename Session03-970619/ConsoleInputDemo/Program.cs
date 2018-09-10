using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Please Enter Your Family:");
            string family = Console.ReadLine();

            Console.WriteLine($"Hello {name} {family}");

            Console.ReadKey();
        }
    }
}
