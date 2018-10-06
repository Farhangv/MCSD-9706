using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //<>
            List<string> names = new List<string>();
            
            names.Add("C#");
            names.Add("Java");
            names.Add("TypeScript");
            //names.Add(123);
            names.Add("HTML");
            names.Add("JavaScript");

            names.Sort();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            names.RemoveAt(2);
            Console.WriteLine("----------------");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            
        }
    }
}
