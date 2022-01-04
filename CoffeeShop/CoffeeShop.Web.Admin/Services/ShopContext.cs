using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoffeeShop.Web.Admin.Models;




namespace CoffeeShop.Web.Admin.Services
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().ToTable("dbo.User");
            modelBuilder.Entity<ShopModel>().ToTable("dbo.Shop");

        }
    }
}
