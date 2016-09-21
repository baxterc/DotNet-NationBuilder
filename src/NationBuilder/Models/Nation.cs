using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationBuilder.Models
{
    [Table("Nations")]
    public class Nation
    {
        [Key]
        public int Id { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string Name { get; set; }
        public string CurrencyName { get; set; }
        public int GovernmentId { get; set; }
        public int EconomyId { get; set; }
        public int GeographyId { get; set; }
        public int Stability { get; set; }
        public int Capital { get; set; }
        public virtual ICollection<NationsResources> Resources { get; set; }
        public virtual ICollection <City> Cities { get; set; }

    }

}

