using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorDemo
{
    class Child:Parent
    {
        public Child(string name)
            :base(name)
        {
               
        }
    }
}
