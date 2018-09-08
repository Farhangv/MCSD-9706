using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#!");
            var name = "John";
            var balance = "1,000,000";
            Console.WriteLine("Hello " + name + " Your Balance Is " + balance + " Rials");


            Console.WriteLine("Hello {0}, Your Balance Is {1}", name, balance);
            Console.WriteLine($"Hello {name}, Your balance is {balance}");

            Console.ReadKey();
        }
    }
}
