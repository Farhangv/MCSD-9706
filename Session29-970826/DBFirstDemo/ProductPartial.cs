using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstDemo
{
    public partial class Product
    {
        public override string ToString()
        {
            return $"{this.ProductID}.{this.Name} - {this.Color} : {this.ListPrice:C}";
        }
    }
}
