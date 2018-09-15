using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var persianDate = WriteCurrentPersianDate();
            WriteCurrentPersianDate();

            var nums = new int[] { 34,23,78,45,67,12,6,89,56,3,55,66 };
            WriteMinimumNumber(nums);

            var doubles = new double[] { 23.456, 23.135, 11.9, 9.8, 34.65 };
            WriteMinimumNumber(doubles);

            //var booleans = new bool[] { true, false, true, true, false };
            //WriteMinimumNumber(booleans);

            //Console.WriteLine();

            var result = GetMaxNumber(nums);
            Console.WriteLine($"Max: {result}");

            Console.ReadKey();
        }

        static void WriteCurrentPersianDate()
        {
            var pc = new PersianCalendar();
            Console.WriteLine($"{pc.GetYear(DateTime.Now):0000}/{pc.GetMonth(DateTime.Now):00}/{pc.GetDayOfMonth(DateTime.Now):00}");
        }

        static void WriteMinimumNumber(int[] numbers)
        {
            var min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }
            Console.WriteLine($"Min: {min}");
        }

        static void WriteMinimumNumber(double[] numbers)
        {
            var min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }
            Console.WriteLine($"Min: {min}");

        }

        static int GetMaxNumber(int[] numbers)
        {
            var max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            //if (numbers.Length > 2)
            //    return max;
            //else
            //    return max;

            return max;

        }
    }
}
