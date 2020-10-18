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
        public DbSet<Student> Student { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<UDate> UDate { get; set; }

    }
}
