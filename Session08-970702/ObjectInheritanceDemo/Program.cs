using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "John";
            p.Family = "Doe";
            p.Id = 10;

            Person p2 = new Person()
            {
                Name = "David",
                Family = "Doe",
                Id = 10
            };

            
            Console.WriteLine(p.GetType());
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.Equals(p2));

            //List<Person> people = new List<Person>();
            //people.Add(new Person() { Name = "Ross", Family = "Geller", Id = 1 });
            //people.Add(new Person() { Name = "Chandler", Family = "Bing", Id = 2 });

            //for (int i = 0; i < people.Count; i++)
            //{
            //    Console.WriteLine(people[i]);
            //}

            //people.Remove(new Person() { Name = "Ross", Family = "Geller", Id = 1 });

            //for (int i = 0; i < people.Count; i++)
            //{
            //    Console.WriteLine(people[i]);
            //}

            Console.ReadKey();
        }
    }
}
