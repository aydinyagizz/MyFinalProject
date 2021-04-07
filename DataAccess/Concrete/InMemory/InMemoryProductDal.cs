﻿using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //global değişkenlerin adları genellikle _ ile verilir.

        public InMemoryProductDal() //constructor
        {
            //veritabanı varmış gibi simüle ediyoruz.
            _products = new List<Product> { //ürünleri barındıran liste.
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Mouse", UnitPrice=85, UnitsInStock=1}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query - Dile Gömülü Sorgulama.

            //SingleOrDefault(); ürünleri tek tek dolaşmaya yarar. =>; Lambda işareti denir. p; tek tek dolaşırken verdiğimiz takma isim.
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            //her p için p nin Id'si benim parametre ile gönderdiğim ürünün Id'sine eşitse onun referansını productToDelete'ye eşitle diyoruz.

            _products.Remove(productToDelete);
            
        }

        public List<Product> GetAll()
        {
            return _products; //tümünü döndürür.
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //where; içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür.
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //SingleOrDefault(); ürünleri tek tek dolaşmaya yarar. =>; Lambda işareti denir. p; tek tek dolaşırken verdiğimiz takma isim.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //her p için p nin Id'si benim parametre ile gönderdiğim ürünün Id'sine eşitse onun referansını productToDelete'ye eşitle diyoruz.

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
