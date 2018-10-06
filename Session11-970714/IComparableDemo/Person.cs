using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Person:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int BirthYear { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                
                var other = obj as Person;
                if (this.Family == other.Family)
                    return this.Name.CompareTo(other.Name);
                else
                    return this.Family.CompareTo(other.Family);
            }
            else
                return 0;
        }

        public override string ToString()
        {
            return $"{Id}.{Name} {Family} \t {BirthYear}";
        }
    }

    class PersonBirthComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return (((Person)x).BirthYear).CompareTo(((Person)y).BirthYear);
        }
    }
}
