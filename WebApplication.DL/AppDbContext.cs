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

            // CreatingDigitalImage to Evidence
            modelBuilder.Entity<CreatingDigitalImage>()
                .HasOne(cdi => cdi.Evidence)
                .WithOne(e => e.CreatingDigitalImage)
                .HasForeignKey<Evidence>(e => e.CreatingDigitalImageId);

            // GraphicProducts to Processes
            modelBuilder.Entity<GraphicProduct>()
                .HasOne(gp => gp.Process)
                .WithOne(p => p.GraphicProduct)
                .HasForeignKey<Process>(p => p.GraphicProductId);

            // GraphicProduct to FinalProduct
            modelBuilder.Entity<GraphicProduct>()
                .HasOne(gp => gp.FinalProduct)
                .WithOne(fp => fp.GraphicProduct)
                .HasForeignKey<FinalProduct>(fp => fp.GraphicProductId);
        }

        public DbSet<CreatingDigitalImage>  CreatingDigitalImages { get; set; }
        public DbSet<Evidence>              Evidences { get; set; }
        public DbSet<FinalProduct>          FinalProducts { get; set; }
        public DbSet<GraphicProduct>        GraphicProducts { get; set; }
        public DbSet<PrimarySource>         PrimarySources { get; set; }
        public DbSet<Process>               Processes { get; set; }
        public DbSet<Resource>              Resources { get; set; }
        public DbSet<SecondarySource>       SecondarySources { get; set; }
    }
}
