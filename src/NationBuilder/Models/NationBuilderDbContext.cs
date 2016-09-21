using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace NationBuilder.Models
{
    public class NationBuilderDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Economy> Economies { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Geography> Geographies { get; set; }
        public virtual DbSet<Government> Governments { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }

        public NationBuilderDbContext()
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NationBuilder;integrated security = True");
        }
    }
}
