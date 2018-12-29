using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropMan.ViewModels
{
    public class PropertyItemViewModel
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public string Title { get; set; }
        public string PriceText { get; set; }
    }
}