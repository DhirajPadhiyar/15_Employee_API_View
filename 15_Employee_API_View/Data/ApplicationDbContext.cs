using _15_Employee_API_View.Models;
using Microsoft.EntityFrameworkCore;

namespace _15_Employee_API_View.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(p => p.Name)
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .Property(p => p.Salary)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
