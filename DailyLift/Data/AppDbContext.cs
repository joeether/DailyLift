using DailyLift.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DailyLift.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<LiftItem> LiftItems => Set<LiftItem>();
    }
}