using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
                {
                    new Person { Id = 1, Name = "Ross", Family = "Geller", BirthYear = 1350 },
                    new Person { Id = 2, Name = "Chandler" , Family = "Bing", BirthYear = 1360},
                    new Person { Id = 3, Name = "Monica", Family = "Geller", BirthYear = 1340}
                };

            Array.Sort(people,new PersonBirthComparer());

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }
}
