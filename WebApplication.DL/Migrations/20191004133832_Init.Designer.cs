﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication.DL;

namespace WebApplication.DL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191004133832_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication.Core.Entities.Catalog", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("FriendlyUrl");

                    b.Property<string>("HeadCatalogId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("HeadCatalogId");

                    b.ToTable("Catalogs");
                });

            modelBuilder.Entity("WebApplication.Core.Entities.Catalog", b =>
                {
                    b.HasOne("WebApplication.Core.Entities.Catalog", "HeadCatalog")
                        .WithMany("NestedCatalogs")
                        .HasForeignKey("HeadCatalogId");
                });
#pragma warning restore 612, 618
        }
    }
}
