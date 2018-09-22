using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
                        /*Instance
                         * Object
                         * نمونه
                         * شیئ
                         */
            Student std = new Student();
            //std.name = "Ross";
            std.setName("Ross");
            //std.family = "Geller";
            std.setFamily("Geller");

            //std.TestMethod();
            Console.WriteLine("Enter Student's Average:");
            var avg = double.Parse(Console.ReadLine());
            std.setAverage(avg);

            Console.WriteLine($"{std.getName()} {std.getFamily()}");
            Console.WriteLine($"Average: {std.getAverage()}");

            Console.ReadKey();
        }
        
    }

}
