using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent c = new Child();

            ((Child)c).Sample();

            Console.ReadKey();
        }
    }
}
