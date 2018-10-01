using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorDemo
{
    class Parent
    {
        public string Name { get; set; }
        public Parent(string _name)
        {
            Console.WriteLine("New Parent Instace Created!");
            Name = _name;
        }
        //public Parent()
        //{

        //}


        ~Parent()
        {
            Console.WriteLine("Parent Destructed");
        }
    }
}
