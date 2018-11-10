using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Course
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public int Price {
            get {
                return Duration * 10000;
            }
        }
    }
}