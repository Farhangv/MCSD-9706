using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookDemo
{
    public class Contact
    {
        private string name;
        private string family;
        private string phone;
        private string cellPhone;

        public string getName()
        {
            return name;
        }
        public void setName(string _name)
        {
            name = _name;
        }

        public string getFamily()
        {
            return family;
        }

        public void setFamily(string _family)
        {
            family = _family;
        }

        public string getPhone()
        {
            return phone;
        }

        public void setPhone(string _phone)
        {
            if (_phone[0] != '0')
                _phone = $"021{_phone.Substring(1, _phone.Length - 1)}";
            phone = _phone;
        }

        public string getCellPhone()
        {
            return cellPhone;
        }

        public void setCellPhone(string _cellPhone)
        {
            if (_cellPhone.Substring(0, 2) == "00")
                _cellPhone = $"+{_cellPhone.Substring(2, _cellPhone.Length - 2)}";
            else if (_cellPhone[0] == '0')
                _cellPhone = $"+98{_cellPhone.Substring(1, _cellPhone.Length - 1)}";

            cellPhone = _cellPhone;
        }


    }
}
