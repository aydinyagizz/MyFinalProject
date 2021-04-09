using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //context; Db tabloları ile proje classlarını bağlamak.
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //bu metot proje hangi veritabanı ile ilişkiliyi belirteceğimiz yer.
        {
            //Trusted_Connection=true; kullanıcı adı ve şifre gerektirmez.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; } //benim hangi nesnem veritabanından hangi nesneye karşılık gelecek onu belirtiyoruz.
        public DbSet<Category> Categories { get; set; } //benim hangi nesnem veritabanından hangi nesneye karşılık gelecek onu belirtiyoruz.
        public DbSet<Customer> Customers { get; set; } //benim hangi nesnem veritabanından hangi nesneye karşılık gelecek onu belirtiyoruz.
    }
}
