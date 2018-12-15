using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIDGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Guid.NewGuid().ToString());
            Console.ReadKey();
        }
    }
}
