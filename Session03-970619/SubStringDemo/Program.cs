using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Text:");
            var text = Console.ReadLine();
            Console.WriteLine(text);
            Console.WriteLine($"Your text length is {text.Length}");
            Console.WriteLine(text.Substring(2,4));
            Console.ReadKey();

        }
    }
}
