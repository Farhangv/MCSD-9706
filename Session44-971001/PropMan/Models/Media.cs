using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PropMan.Models
{
    [Table("Media")]
    public class Media
    {
        public int Id { get; set; }
        public byte[] FileContent { get; set; }
        [MaxLength(100)]
        public string OriginalFileName { get; set; }
        [MaxLength(30)]
        public string ContentType { get; set; }
        public int FileSize { get; set; }

        public Property Property { get; set; }
        public int PropertyId { get; set; }
    }
}