using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, Student> students = new Dictionary<int, Student>();
            //students.Add(123, new Student());
            //students.Add(456, new Student());

            ////students.Remove(123);

            //foreach (KeyValuePair<int, Student> item in students)
            //{
            //    Console.WriteLine($"{item.Key} {item.Value}");
            //}


            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third"); 
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.WriteLine("----------------");
            Queue<string> q = new Queue<string>();
            q.Enqueue("First");
            q.Enqueue("Second");
            q.Enqueue("Third");

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            Console.WriteLine("--------------------");

            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(12);
            sortedSet.Add(9);
            sortedSet.Add(6);
            sortedSet.Add(14);
            sortedSet.Add(8);
            sortedSet.Add(23);

            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }

            

            Console.ReadKey();
        }
    }
}
