using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PropMan.Models
{
    [Table("Property")]
    public class Property
    {
        [Display(Name = "شناسه")]
        public int Id { get; set; }
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
        [Display(Name = "فعال")]
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        [Display(Name = "تاریخ اعتبار")]
        public DateTime? ValidUntilDate { get; set; }
        [Display(Name = "نوع آگهی")]
        public AdType AdType { get; set; }
        [Display(Name = "قیمت هر متر مربع")]
        public int SaleUnitPrice { get; set; }
        [Display(Name = "رهن")]
        public int RentDiposite { get; set; }
        [Display(Name = "اجاره ماهانه")]
        public int RentMonthly { get; set; }
        public virtual ApplicationUser CreatedUser { get; set; }
        public string CreatedUserId { get; set; }
        [Display(Name = "منطقه")]
        public Location Location { get; set; }
        [Display(Name = "منطقه")]
        public int LocationId { get; set; }
        [Display(Name = "نوع ملک")]
        public PropertyType PropertyType { get; set; }
        [Display(Name = "نوع ملک")]
        public int PropertyTypeId { get; set; }

        public virtual ICollection<Media> Medias { get; set; }
    }
}