using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInitializerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
                {
                    "Chandler",
                    "Ross",
                    "Sheldon",
                    "Penni",
                    "Monica"
                };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            //Console.WriteLine(names[6]);
            Console.ReadKey();
        }
    }
}
