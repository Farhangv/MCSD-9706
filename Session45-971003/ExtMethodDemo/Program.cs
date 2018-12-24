using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = StringExtensions.ToInt("123");
            int b = "123".ToInt();
        }
    }
}
