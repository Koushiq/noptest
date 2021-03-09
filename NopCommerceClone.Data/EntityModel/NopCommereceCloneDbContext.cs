using Microsoft.EntityFrameworkCore;
using NopCommerceClone.Data.EntityModel;
using NopCommerceClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NopCommerceClone.Data
{
    public class NopCommereceCloneDbContext : DbContext
    {
        public DbSet<Catelog> Catelogs { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Product> Products { get; set; }
        public NopCommereceCloneDbContext(DbContextOptions<NopCommereceCloneDbContext> options)
        : base(options)
        {}

        //public NopCommereceCloneDbContext()
        //{
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catelog>().ToTable("Catelog");
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<Product>().ToTable("Product");


            //fluent api validation!
            modelBuilder.Entity<Admin>()
            .HasIndex(u => u.Username)
            .IsUnique();

            modelBuilder.Entity<Product>()
                .HasOne(s => s.Catelog)
                .WithMany(s => s.Products)
                .HasForeignKey(s => s.CatelogID)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
