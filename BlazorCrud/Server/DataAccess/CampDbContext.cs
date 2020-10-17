using BlazorCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.DataAccess
{
    public class CampDbContext : DbContext
    {
        public CampDbContext(DbContextOptions<CampDbContext> options)
            : base(options) { }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Camp> Camp { get; set; }
        public DbSet<School> School { get; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Class> Classes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>()
                .HasMany(s => s.Classes)
                .WithOne();
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Classes)
                .WithOne();
            modelBuilder.Entity<Camp>()
                .HasMany(c => c.Classes)
                .WithOne();
        }
    }
}
