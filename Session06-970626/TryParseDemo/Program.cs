using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number:");
            //var number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Log(number));
            if(int.TryParse(Console.ReadLine(), out int number))
                Console.WriteLine(Math.Log(number));
            else
                Console.WriteLine("Please enter a valid number!");
            Console.ReadKey();

        }
    }
}
