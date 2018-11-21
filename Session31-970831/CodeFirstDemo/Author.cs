using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    [Table("Author", Schema = "Books")]
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Nationality { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
