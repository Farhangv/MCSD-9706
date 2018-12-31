using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropMan.ViewModels
{
    public class PropertyAddMediaViewModel
    {
        public int PropertyId { get; set; }
        public HttpPostedFileBase Media { get; set; }
    }
}