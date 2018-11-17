using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>()
            {
                "Java","C#", "Python",
                "Perl", "C++", "JavaScript", "TypeScript", "C", "Ruby",
                "R", "Go","Haskell"
            };

            //(1) LINQ
            //var filteredNames = from n in names
            //                    //where n.Contains("Script")
            //                    orderby n descending
            //                    select n;
            
            //(2) LINQ Extension Methods

            var filteredNames = names
                .Where(n => n.StartsWith("C"))
                .Select(n => n);

            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
