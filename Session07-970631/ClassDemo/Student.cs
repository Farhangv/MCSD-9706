using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Student
    {
        ////Nested Class
        //class Course
        //{

        //}

        private string name;
        private string family;
        private double average;

        public void setAverage(double _average)
        {
            if(_average >= 0 && _average <= 100)
                average = _average;
            else
                Console.WriteLine("Invalid Average!");
        }
        public double getAverage()
        {
            return average / 5;
        }

        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }

        public void setFamily(string _family)
        {
            family = _family;
        }
        public string getFamily()
        {
            return family;
        }

        public void TestMethod()
        {
            Console.WriteLine("Test!");
        }
    }
}
