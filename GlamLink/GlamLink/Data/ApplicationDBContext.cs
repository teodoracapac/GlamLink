using  GlamLink.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;


namespace GlamLink.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admins> Admins { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Clothes> Clothes { get; set; }
        public DbSet<Outfits> Outfits { get; set; }
        public DbSet<Complaints> Complaints { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<OutfitClothes> OutfitClothes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Complaints>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.idUser)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Complaints>()
                .HasOne(c => c.Admin)
                .WithMany()
                .HasForeignKey(c => c.idAdmin)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
