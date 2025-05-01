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
    }

}
