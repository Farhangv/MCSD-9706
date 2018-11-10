using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic p = new ExpandoObject();
            p.Name = "John";
            p.Family = "Doe";

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Family);
            Console.WriteLine(p.Age);

            Console.ReadKey();
            
        }
    }

    class Person {
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
