using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[]
                {
                    "C#",
                    "Java",
                    "PHP",
                    "Perl",
                    "HTML",
                    "Python"
                };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();

        }
    }
}
