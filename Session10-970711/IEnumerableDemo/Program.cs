using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Exam exam = new Exam();
            exam.Questions = new Question[]
                {
                    new Question() { Text = "What's your name?" },
                    new Question() { Text = "Describe OOP" },
                    new Question() { Text = "Describe GC" },
                    new Question() { Text = "What's the difference between Interface and Abstract Class?" }
                };

            foreach (Question question in exam)
            {
                Console.WriteLine(question.Text);
            }

            Console.ReadKey();
        }
    }
}
