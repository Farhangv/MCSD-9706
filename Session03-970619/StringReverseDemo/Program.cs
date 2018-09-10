using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username:");
            var username = Console.ReadLine().ToLower();
            Console.Write("Password:");
            var password = Console.ReadLine();
            if (username == "admin" && password == "Q!@q12")
            {
                while (true)
                {
                    Console.Write("Text:");
                    var text = Console.ReadLine();
                    if (text == "exit")
                        break;
                    var index = text.Length - 1;
                    do
                    {
                        Console.Write(text.Substring(index, 1));
                        //Console.Write(text[index]);
                    } while (--index >= 0);
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Username & Password Combination is invalid!");
            Console.ReadKey();
        }
    }
}
