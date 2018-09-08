using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            int age;
            age = 10;
            Random r;
            r = new Random();

            int balance = 1000000;

            Console.WriteLine("Hello");
            string name = "John";
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(r.Next());

            var family = "Doe";
            //var city;
            var now = DateTime.Now;
            var r2 = new Random();
            var pc = new PersianCalendar();
            var i3 = 12;


            {
                var nationalCode = "1234567890";
                Console.WriteLine(nationalCode);
                Console.WriteLine(now);
            }


            string cellPhone = "09123456789";
            cellPhone = null;
            string phone = null;

            //int i4 = null;

            int? i5 = null;
            //Nullable<int> i6 = null;
            string address = null;
            Console.WriteLine(address);
            //int i6;
            //Console.WriteLine(i6);
            Console.ReadKey();
        }
    }
}
