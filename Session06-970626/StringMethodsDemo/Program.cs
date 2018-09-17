using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("      Hello      " + "John");
            Console.WriteLine("      Hello      ".Trim() + "John");
            Console.WriteLine("C# Is a Good Programming language"[3]);
            Console.WriteLine("Javascript is a client-side programming language"
                    .Contains("C#"));
            Console.WriteLine("Javascript is a client-side programming language"
                    .Replace("Java", "VB"));

            Console.WriteLine("Please Enter Persian Date:");
            var input = Console.ReadLine().Split('/');
            Console.WriteLine($"Year: {input[0]}");
            Console.WriteLine($"Month: {input[1]}");
            Console.WriteLine($"Day: {input[2]}");
            Console.ReadKey();
        }
    }
}
