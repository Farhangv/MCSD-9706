using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            object p = new Person();
            object o = new object();
            Person e = new Employee();
            object e2 = new Employee();
            object o2 = "Salaam";
            object o3 = 12.45;
            object o4 = DateTime.Now;
            //Person o = new object();

            //((Person)p)
            //(p as DateTime);

            Console.ReadKey();
        }
    }
}
