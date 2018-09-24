using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInheritanceDemo
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public override int GetHashCode()
        {
            return this.Id;
        }
        public override string ToString()
        {
            return $"{Id},{Name} {Family}";
        }

        public override bool Equals(object obj)
        {
            //return this.GetHashCode() == obj.GetHashCode();
            //Person other = ((Person)obj);
            Person other = obj as Person;
            return this.Name == other.Name && this.Family == other.Family;
        }
    }
}
