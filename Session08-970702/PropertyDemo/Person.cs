using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    class Person
    {
        //private string name;
        private string family;
        private string nationalCode;


        public string Name { get; set; }

        //public string Name
        //{
        //    get { return name; }
        //    set {
        //        if (value.Length >= 3)
        //            name = value;
        //    }
        //}

        public string Family
        {
            get { return family; }
            set { family = value; }
        }

        public string NationalCode
        {
            get {
                return nationalCode;
            }
            set {
                if (value.Length == 10)
                    nationalCode = value;
                else
                    Console.WriteLine("Invalid National Code");
            }
        }
        private string website;

        public string Website
        {
            get { return website; }
            set { website = value; }
        }

        private string cellPhone;
        public string CellPhone {
            get
            {
                return cellPhone;
            }
            set {
                if (value.StartsWith("09"))
                    cellPhone = value;
                else
                    Console.WriteLine("Invalid CellPhone");
            }
        }
        public string Email { get; set; }
        public string Phone { get; set; }


        //public void setNationalCode(string _nationalCode)
        //{
        //    if (_nationalCode.Length == 10)
        //        nationalCode = _nationalCode;

        //    else
        //        Console.WriteLine("Invalid National Code");
        //}
        //public string getNationalCode()
        //{
        //    return nationalCode;
        //}
    }
}
