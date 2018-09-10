using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwithCaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var score = int.Parse(Console.ReadLine());
            //switch (score)
            //{
            //    case 90:
            //    case 91:
            //    case 92:
            //        Console.WriteLine("A+");
            //        break;
            //    case 80:
            //        Console.WriteLine("A");
            //        break;

            //    default:
            //        Console.WriteLine("Value Is Not Valid");
            //        break;
            //}

            //Console.WriteLine("pHp".ToUpper());
            //Console.WriteLine("jAVa".ToLower());

            Console.WriteLine("Enter Programming Language Name:");

            switch (Console.ReadLine().ToLower())
            {
                case "c#":
                    Console.WriteLine("OO Language From Microsoft"); ;
                    break;
                case "php":
                    Console.WriteLine("OO Server Side Programming Language");
                    break;
                case "java":
                    Console.WriteLine("Cross Platform programming language");
                    break;
                default:
                    Console.WriteLine("Language is not recognized");
                    break;
            }
            Console.ReadKey();
        }
    }
}
