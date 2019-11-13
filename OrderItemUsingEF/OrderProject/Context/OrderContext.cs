using Microsoft.EntityFrameworkCore;
using OrderProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProject.Context
{
    class OrderContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<Item> Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-J33QLHE\SQLDB;Database=Order1DB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Item>().HasData(new Item {
            Iid=1,
            Iname="Nippon Blobby",
            Price=200
            
            },new Item
            {
                Iid = 2,
                Iname = "Smiley",
                Price = 250



            }
                );
            model.Entity<Order>().HasData(new Order
            {
                Orderid = 01,
                ODate = DateTime.Now,
                DDate = DateTime.Now.AddDays(7),
                Iid=1


            }, new Order
            {
                Orderid = 02,
                ODate = DateTime.Now,
                DDate = DateTime.Now.AddDays(7),
                Iid = 2



            }
               ); ;
        }

    }
}
