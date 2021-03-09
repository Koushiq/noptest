using NopCommerceClone.Data.EntityModel;
using NopCommerceClone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NopCommerceClone.Data
{
    public class DbInitializer
    {
        public static void Initialize(NopCommereceCloneDbContext context)
        {
            context.Database.EnsureCreated(); 

            if(context.Products.Any())
            {
                return;
            }

            #region seeds
            var admins = new Admin[]
            {
                new Admin
                {
                    
                    Password="1234",
                    RegisteredAt=DateTime.Now,
                    Username="koushiq"
                },
                new Admin
                {
                    
                    Password="1234",
                    RegisteredAt=DateTime.Now,
                    Username="koushiq1"
                }
            };

            foreach (Admin a in admins)
            {
                context.Admins.Add(a);
            }

            context.SaveChanges();


            var catelogs = new Catelog[]
            {
                new Catelog
                {
                    
                    CatelogName="Electronics",
                    AddedAt=DateTime.Now,
                    AdminID=1
                }
            };

            foreach (var c in catelogs)
            {
                context.Catelogs.Add(c);
            }
            context.SaveChanges();


            var products = new Product[]
            {
                new Product
                {
                    Price=10.00,
                    ProductName="Raspberry Pi",
                    AddedAt=DateTime.Now,
                    AdminID=1,
                    CatelogID=1,

                },
                new Product
                {
                    Price=100.00,
                    ProductName="LattePanda",
                    AddedAt=DateTime.Now,
                    AdminID=2,
                    CatelogID=1,
                },
                new Product
                {
                    Price=22.33,
                    ProductName="Xiaomi",
                    AddedAt=DateTime.Now,
                    AdminID=1,
                    CatelogID=1,
                }
            };

            foreach (Product p in products)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();
            #endregion
        }
    }
}
