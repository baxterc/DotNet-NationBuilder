using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NationBuilder.Models
{
    [Table("Geographies")]
    public class Geography
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
