using JobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOption)
        {

        }
        public DbSet<Models.Job> Job { get; set; }
        public DbSet<Models.Company> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().HasKey(j => j.JobId);
            modelBuilder.Entity<Job>().ToTable("jobs");
            modelBuilder.Entity<Company>().Property(u => u.CompanyId).HasConversion<int>();

            modelBuilder.Entity<Company>().HasKey(c=>c.CompanyId);
            modelBuilder.Entity<Company>().ToTable("company");

        }
    }
}
