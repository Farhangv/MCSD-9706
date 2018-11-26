using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PropMan.Models
{
    [Table("Location")]
    public class Location
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(100)]
        public string District { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}