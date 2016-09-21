using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NationBuilder.Models
{
    [Table("NationsResources")]
    public class NationsResources
    {
        [Key]
        public int Id { get; set; }
        public int NationId { get; set; }
        public int ResourceId { get; set; }
        public int Amount { get; set; }
    }
}
