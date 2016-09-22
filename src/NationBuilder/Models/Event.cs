using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NationBuilder.Models
{
    [Table("Events")]
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string TextResponse1 { get; set; }
        public string TextResponse2 { get; set; }
        public string TextResponse3 { get; set; }
        public string ValueResponse1 { get; set; }
        public string ValueResponse2 { get; set; }
        public string ValueResponse3 { get; set; }
    }
}
