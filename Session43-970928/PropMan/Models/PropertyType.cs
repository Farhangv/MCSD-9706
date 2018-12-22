using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PropMan.Models
{
    [Table("PropertyType")]
    public class PropertyType
    {
        public int Id { get; set; }
        [MaxLength(15, ErrorMessage = "حداکثر تعداد کاراکتر ورودی {1} کاراکتر است"),
            Required(ErrorMessage = "مقدار تهی قابل قبول نیست"),
            Display(Name = "نام")]
        public string Name { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}