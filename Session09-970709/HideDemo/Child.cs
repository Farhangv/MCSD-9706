using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideDemo
{
    class Child:Parent
    {
        public new void Sample()
        {
            Console.WriteLine("From Child!");
        }
    }
}
