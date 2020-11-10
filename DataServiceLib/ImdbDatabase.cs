using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataServiceLib
{
    public class ImdbDatabase : DbContext
    {
 
       // public static readonly ILoggerFactory MyLoggerFactory
         //   = LoggerFactory.Create(builder => { builder.AddConsole(); });
        	
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<title_basics> title_basics { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseLoggerFactory(MyLoggerFactory);
            optionsBuilder.UseNpgsql("host = localhost; db = testmovie; uid = postgres; pwd =1234qwer");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            NewMethod(modelBuilder);


            /*modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnName("categoryid");
            modelBuilder.Entity<Category>().Property(x => x.Name).HasColumnName("categoryname");
            modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnName("description");

            modelBuilder.Entity<Product>().ToTable("products");
            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("productid");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("productname");
            modelBuilder.Entity<Product>().Property(x => x.CategoryId).HasColumnName("categoryid");*/
        }

        private static void NewMethod(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<title_basics>().ToTable("title_basics");
            modelBuilder.Entity<title_basics>().Property(x => x.tconst).HasColumnName("tconst");
        }
    }


}