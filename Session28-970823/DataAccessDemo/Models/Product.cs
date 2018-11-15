using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double ListPrice { get; set; }

        public override string ToString()
        {
            return $"{this.ProductId}.{this.Name} : {this.ListPrice:C}";
        }
    }
}
