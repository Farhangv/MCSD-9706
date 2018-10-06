using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(123);
            al.Add("C#");
            al.Add(DateTime.Now);
            al.Add(new Person());

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");

            al.Remove("C#");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            al.RemoveAt(2);
            Console.WriteLine("-----------------");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }


            al.Insert(2, "Java");
            Console.WriteLine("-----------------");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine(al.IndexOf("Java"));
            Console.WriteLine(al.Contains("PHP"));
            al[al.IndexOf("Java")] = "PHP";
            Console.WriteLine("-----------------");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            //al.Clear();
            //Console.WriteLine("-----------------");
            //foreach (var item in al)
            //{
            //    Console.WriteLine(item);
            //}
            //al.Add(new Person());
            //al.Sort();
            

            Console.ReadKey();
        }


    }
    class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
