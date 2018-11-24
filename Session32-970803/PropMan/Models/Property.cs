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
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public int Area { get; set; }
        public int BedRoomsCount { get; set; }
        public HousePosition Position { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ValidUntilDate { get; set; }

        public AdType AdType { get; set; }
        public int SaleUnitPrice { get; set; }
        public int RentDiposite { get; set; }
        public int RentMonthly { get; set; }
        public virtual ApplicationUser CreatedUser { get; set; }
        public string CreatedUserId { get; set; }

        public Location Location { get; set; }
        public int LocationId { get; set; }

        public PropertyType PropertyType { get; set; }
        public int PropertyTypeId { get; set; }

        public virtual ICollection<Media> Medias { get; set; }
    }
}