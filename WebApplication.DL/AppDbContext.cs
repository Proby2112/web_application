using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication.Core.Entities;

namespace WebApplication.DL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Catalog>()
                .HasMany(c => c.NestedCatalogs)
                .WithOne(nc => nc.HeadCatalog)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }

        public DbSet<Catalog>  Catalogs { get; set; }
    }
}
