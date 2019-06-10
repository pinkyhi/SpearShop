using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpearShopWeb.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<CategoryGood> CategoryGoods { get; set; }
        public DbSet<OrderGood> OrderGoods { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Img> Imgs { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Delivery_Type> Delivery_Types { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=password;database=spearshop;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryGood>()
                .HasKey(cg => new { cg.Good_Id, cg.Category_Id });
            modelBuilder.Entity<CategoryGood>()
                .HasOne(cg => cg.Good)
                .WithMany(g => g.CategoryGoods)
                .HasForeignKey(cg => cg.Good_Id);
            modelBuilder.Entity<CategoryGood>()
                .HasOne(cg => cg.Category)
                .WithMany(c => c.CategoryGoods)
                .HasForeignKey(cg => cg.Category_Id);

            modelBuilder.Entity<OrderGood>()
    .HasKey(og => new { og.Good_Id, og.Order_Id });
            modelBuilder.Entity<OrderGood>()
                .HasOne(og => og.Good)
                .WithMany(g => g.OrderGoods)
                .HasForeignKey(og => og.Good_Id);
            modelBuilder.Entity<OrderGood>()
                .HasOne(og => og.Order)
                .WithMany(o => o.OrderGoods)
                .HasForeignKey(og => og.Order_Id);
        }
    }
}
