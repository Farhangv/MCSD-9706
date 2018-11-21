using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    [Table("Book", Schema = "Books")]
    public class Book
    {
        public Book()
        {
            Price = 1000;
            PriceUnit = CodeFirstDemo.PriceUnit.Toman;
        }
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Title { get; set; }
        [StringLength(13, MinimumLength = 10), Required]
        public string ISBN { get; set; }
        public double? Price { get; set; }
        public Nullable<PriceUnit> PriceUnit { get; set; }

        public Category Category { get; set; }
        public int? CategoryId { get; set; }

        public virtual Publisher Publisher { get; set; }
        public int PublisherId { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
    public enum PriceUnit
    {
        Toman,
        Rial,
        Dollar
    }
}
