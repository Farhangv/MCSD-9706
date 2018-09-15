using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValRefDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            b++;
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine("---------------------");

            string c = "Hello";
            string d = c;
            d += " C#";
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"d: {d}");

            Console.WriteLine("---------------------");
            int[] e = new int[] { 10 };
            int[] f = e;
            f[0]++;
            Console.WriteLine($"e[0]: {e[0]}");
            Console.WriteLine($"f[0]: {f[0]}");

            Console.ReadKey();
        }
    }
}
