using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Models;

namespace WebSite.DataAccess
{
    public class WarmingUpDbContext : DbContext
    {
        public DbSet<Exercise> Exercises { get; set; }

        public WarmingUpDbContext(DbContextOptions<WarmingUpDbContext> options)
            : base(options)
        {
        }
    }
}
