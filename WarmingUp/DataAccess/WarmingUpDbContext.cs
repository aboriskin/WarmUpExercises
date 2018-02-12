using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public class WarmingUpDbContext : DbContext
    {
        public DbSet<ExerciseEntity> Exercises { get; set; }

        public WarmingUpDbContext(DbContextOptions<WarmingUpDbContext> options)
            : base(options)
        {
        }
    }
}
