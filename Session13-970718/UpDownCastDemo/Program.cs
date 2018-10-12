using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownCastDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent c = new Child();
            //((Child)c)
            //(c as Child)
            if(c is Child)
                Console.WriteLine("Child");
            else
            {
                Console.WriteLine("Not Child");
            }
        }
    }
}
