using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace NationBuilder.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int NationId { get; set; }

        public ApplicationUser()
        {
            NationId = 0;
        }
    }
}
