using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //int min, max;
            //double avg;
            int[] nums = new int[100];
            var r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(1000, 2000);
            }

            MathOperations(nums, out int min, out int max, out double avg);
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Average: {avg}");

            Console.ReadKey();

        }

        static void MathOperations(int[] numbers,out int min,out int max,out double avg)
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
