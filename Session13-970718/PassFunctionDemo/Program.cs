using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassFunctionDemo
{
    public delegate bool NumberFilter(int number);
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 4, 5, 64, 3, 4, 66, 78, 33, 23, 45, 66, 22, 12, 34, 45, 56, 78, 84 };
            //WriteFilteredNumbers(numbers, OddFilter);
            //WriteFilteredNumbers(numbers, EvenFilter);
            //WriteFilteredNumbers(numbers, 
            //    (x) 
            //    => 
            //    {
            //        return x % 2 != 0;
            //    });

            //WriteFilteredNumbers(numbers,
            //    x
            //    =>
            //    x % 2 != 0);

            WriteFilteredNumbers(numbers, x => x % 2 != 0);
            Console.ReadKey();
        }

        static bool OddFilter(int number)
        {
            return number % 2 != 0;
        }

        static bool EvenFilter(int number)
        {
            return number % 2 == 0;
        }

        static void WriteFilteredNumbers(int[] numbers, NumberFilter filter)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(filter(numbers[i]))
                    Console.WriteLine(numbers[i]);
            }
        }
    }
}
