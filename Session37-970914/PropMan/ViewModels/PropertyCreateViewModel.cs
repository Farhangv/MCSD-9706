using PropMan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PropMan.ViewModels
{
    public class PropertyCreateViewModel
    {
        [MaxLength(50), Display(Name = "عنوان")]
        public string Title { get; set; }
        [Display(Name = "مساحت")]
        public int Area { get; set; }
        [Display(Name = "تعداد خواب")]
        public int BedRoomsCount { get; set; }
        [Display(Name = "موقعیت واحد")]
        public HousePosition Position { get; set; }
        [Display(Name = "سال ساخت")]
        public int Age { get; set; }
        [Display(Name = "تاریخ اعتبار")]
        public string ValidUntilPersianDate { get; set; }
        [Display(Name = "نوع آگهی")]
        public AdType AdType { get; set; }
        [Display(Name = "قیمت هر متر مربع")]
        public int SaleUnitPrice { get; set; }
        [Display(Name = "رهن")]
        public int RentDiposite { get; set; }
        [Display(Name = "اجاره ماهانه")]
        public int RentMonthly { get; set; }
        [Display(Name = "منطقه")]
        public int LocationId { get; set; }
        [Display(Name = "نوع ملک")]
        public int PropertyTypeId { get; set; }

        [Display(Name = "توضیحات"),AllowHtml]
        public string Description { get; set; }
    }
}