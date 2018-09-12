using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array size:");
            var count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a \"Number\":");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]}\t");
            //}
            Console.WriteLine(string.Join("\t", numbers));

            Console.WriteLine("-------------------------");
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console
                .WriteLine
                (
                    //Convert.ToDouble(sum)/Convert.ToDouble(numbers.Length)
                    Convert.ToDouble(sum)/numbers.Length
                );

            for (int i = 0; i < numbers.Length; i++)
                if(numbers[i] % 2 != 0)
                    Console.Write($"{numbers[i]}\t");

            Console.ReadKey();
        }
    }
}
