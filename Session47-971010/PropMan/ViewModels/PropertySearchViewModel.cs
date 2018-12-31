using PropMan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PropMan.ViewModels
{
    public class PropertySearchViewModel
    {
        
        public bool? SearchForm { get; set; }
        [Display(Name = "عنوان آگهی")]
        public string SearchTitle { get; set; }
        [Display(Name = "مساحت از")]
        public int? SearchAreaFrom { get; set; }
        [Display(Name = "مساحت تا")]
        public int? SearchAreaTo { get; set; }
        [Display(Name = "نوع آگهی")]
        public AdType? SearchAdType { get; set; }
        [Display(Name = "منطقه")]
        public int? SearchLocationId { get; set; }
        public IEnumerable<int> PropertyIds { get; set; }
    }
}