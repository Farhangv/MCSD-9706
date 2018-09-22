using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact[] contacts = new Contact[10];

            for (int j = 0; j < contacts.Length; j++)
            {
                Console.Clear();
                for (int i = 0; i < contacts.Length; i++)
                {
                    if (contacts[i] != null)
                        Console.WriteLine($"{contacts[i].getName()}\t{contacts[i].getFamily()}\t{contacts[i].getCellPhone()}\t{contacts[i].getPhone()}");
                }
                Console.WriteLine("_______________________");
                contacts[j] = new Contact();
                Console.Write("Name:");
                contacts[j].setName(Console.ReadLine());
                Console.Write("Family:");
                contacts[j].setFamily(Console.ReadLine());
                Console.Write("Phone:");
                contacts[j].setPhone(Console.ReadLine());
                Console.Write("CellPhone:");
                contacts[j].setCellPhone(Console.ReadLine());

            }

            Console.WriteLine("Phone Book is Full");

            Console.ReadKey();


        }
    }
}
