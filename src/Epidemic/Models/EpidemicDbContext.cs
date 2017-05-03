using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models
{
    public class EpidemicDbContext : IdentityDbContext<User>
    {
        public EpidemicDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Trait> Traits { get; set; }
        public DbSet<Game> Games { get; set; }

    }
}
