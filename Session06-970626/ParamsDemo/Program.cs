using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //   MathOperations(out int min, out int max, out double average, 
            //       new int[] { 10, 50, 12, 46, 35, 9, 27, 83 });
            MathOperations(out int min, out int max, out double average,
           10, 50, 12, 46, 35, 9, 27, 83, 465,48,14,12 );

            Console.WriteLine("{0} saadjas {1} hjsadjkhas {2}",10, 30, "John");

        }
        static void MathOperations(out int min, out int max, out double avg,params int[] numbers)
        {
            min = numbers[0];
            max = numbers[0];
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];

                sum += numbers[i];
            }
            avg = sum / numbers.Length;
        }

    }
}
