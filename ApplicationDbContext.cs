using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Fashion.Data;

namespace Fashion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Fashion.Data.Clothes> Clothes { get; set; }
        public DbSet<Fashion.Data.Shoes> Shoes { get; set; }
        public DbSet<Fashion.Data.Stores> Stores { get; set; }
    }
}
