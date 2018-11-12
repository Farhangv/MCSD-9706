using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Repository
{
    public class PeopleRepository
    {
        public List<Person> GetAllPeople()
        {
            return new List<Person>() {
                new Person() { Name = "رضا", Family = "رضایی" },
                new Person() { Name = "مریم", Family = "مریمی" },
                new Person() { Name = "پیام", Family = "پیامی" }
            };
        }

        public bool AddPerson(Person person)
        {
            //Add Person To DB
            return true;
        }
    }
}