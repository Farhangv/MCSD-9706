using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    [Table("Contact", Schema = "Publisher")]
    public class Contact
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string ManagerName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public Publisher Publisher { get; set; }

    }
}
