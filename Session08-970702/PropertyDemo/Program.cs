using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.getNationalCode();
            //p.setNationalCode("");
            Console.Write("NationalCode:");
            p.NationalCode = Console.ReadLine();

            Console.WriteLine(p.NationalCode);
            p.CellPhone = "44556688";
            Console.ReadKey();
        }
    }
}
