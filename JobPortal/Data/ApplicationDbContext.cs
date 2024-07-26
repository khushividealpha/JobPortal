using JobPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOption):base(dbContextOption) { }
     

        
        public DbSet<Models.JobModel> Job { get; set; }
        public DbSet<Models.CompanyModel> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobModel>().HasKey(j => j.JobId);
            modelBuilder.Entity<JobModel>().ToTable("jobs");
            modelBuilder.Entity<CompanyModel>().Property(u => u.CompanyId).HasConversion<int>();

            modelBuilder.Entity<CompanyModel>().HasKey(c=>c.CompanyId);
            modelBuilder.Entity<CompanyModel>().ToTable("company");

        }
    }
}
