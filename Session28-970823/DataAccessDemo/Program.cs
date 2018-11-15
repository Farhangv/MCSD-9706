using DataAccessDemo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new ProductRepository();
            var products = repository.GetProducts();

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Console.ReadKey();
        }
    }
}
