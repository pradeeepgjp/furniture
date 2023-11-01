using furniture.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;

namespace furniture.Data
{
    public class PradeepDbContext:DbContext
    {
        public PradeepDbContext(DbContextOptions<PradeepDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pradeep> PradeepList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pradeep>().HasData(
                new Pradeep { Id = 12345, Password = "pradeep" });
        }
    }
}
