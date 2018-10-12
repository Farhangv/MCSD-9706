using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void TextWriter(string name);
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter writer = new TextWriter(WriteHello);
            writer += WriteHowAreYou;
            writer += WriteGoodbye;
            //writer += Sum;

            writer("Ross");

            Console.ReadKey();
        }

        static void WriteHello(string n)
        {
            Console.WriteLine($"Hello {n}");
        }

        static void WriteHowAreYou(string n)
        {
            Console.WriteLine($"How Are You {n}?");
        }

        static void WriteGoodbye(string n)
        {
            Console.WriteLine($"Goodbye {n}");
        }

        static int Sum(int[] numbers)
        {
            return 0;
        }
    }
}
