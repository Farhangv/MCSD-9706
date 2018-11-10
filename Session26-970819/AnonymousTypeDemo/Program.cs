using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new { Name = "John", Family = "Doe" };

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Family);
            //Console.WriteLine(p.Age);

            Console.ReadKey();
        }
    }
}
