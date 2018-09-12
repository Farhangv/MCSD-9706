using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RandomArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Stopwatch sw = new Stopwatch();

            //Console.WriteLine(r.Next(10,99));
            int[] randomNumbers = new int[80];
            sw.Start();
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = r.Next(10, 99);
            }
            sw.Stop();
            Array.Sort(randomNumbers);
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.WriteLine(randomNumbers[i]);
            }
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
