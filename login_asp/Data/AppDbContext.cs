using System.Collections.Generic;
using System.Reflection.Emit;
using WebApplicationGlamLink.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationGlamLink.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Admins> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("Users").HasKey(u => u.IdUsers);
            modelBuilder.Entity<Admins>().ToTable("Admins").HasKey(a => a.IdAdmin);
        }
    }
}
