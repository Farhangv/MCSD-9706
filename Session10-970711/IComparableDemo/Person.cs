using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Person:IComparable
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Name} {Family}, {NationalCode}";
        }
    }

    class PersonComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
}
