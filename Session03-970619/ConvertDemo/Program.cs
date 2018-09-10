using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your score:");
            //var score = int.Parse(Console.ReadLine());
            //var scoreInt = int.Parse(score);
            var score = Convert.ToInt32(Console.ReadLine());
            bool b = true;
            bool b2 = false;

            //if (true)
            //    Console.WriteLine("Explicit True!");

            //if (false)
            //{
            //    Console.WriteLine("Explicit False!");
            //}

            //if(b)
            //{
            //    Console.WriteLine("B is True");
            //}

            if(score > 90)
                Console.WriteLine("A+");
            else if(score > 80)
                Console.WriteLine("A");
            else if(score > 70)
                Console.WriteLine("B+");
            else
                Console.WriteLine("D");

            Console.ReadKey();
        }
    }
}
