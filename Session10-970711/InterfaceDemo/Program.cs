using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculatable[] calculatables = new ICalculatable[]
                {
                    new Customer(),
                    new Student(),
                    new Service(),
                    new Service(),
                    new Customer(),
                    new Employee(),
                    new Product()
                };

            var sum = 0.0;
            for (int i = 0; i < calculatables.Length; i++)
            {
                Console.WriteLine(calculatables[i].GetAmount());
                sum += calculatables[i].GetAmount();
            }

            Console.WriteLine("------------------");
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
