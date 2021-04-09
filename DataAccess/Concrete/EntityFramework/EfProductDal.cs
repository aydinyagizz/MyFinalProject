﻿using DataAccess.Abstrack;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //bir classı new'lediğimizde o bellekten belli bir zamanda düzenli olarak gelir ve bellekten onu atar. using içerisine yazdığımız nesneler using bitince anında bellekten atılır. 
            //using; perfonmans açısından ekliyoruz. belleği hızlıca temizleme.
            //using; IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //veri kaynağını ilişkilendirme. referansı yakalamak.
                addedEntity.State = EntityState.Added; //eklenecek nesne.
                context.SaveChanges(); //ekleme işlemi.
            }
        }

        public void Delete(Product entity)
        {
            //bir classı new'lediğimizde o bellekten belli bir zamanda düzenli olarak gelir ve bellekten onu atar. using içerisine yazdığımız nesneler using bitince anında bellekten atılır. 
            //using; perfonmans açısından ekliyoruz. belleği hızlıca temizleme.
            //using; IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); //veri kaynağını ilişkilendirme. referansı yakalamak.
                deletedEntity.State = EntityState.Deleted; //silinecek nesne.
                context.SaveChanges(); //ekleme işlemi.
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            //bir classı new'lediğimizde o bellekten belli bir zamanda düzenli olarak gelir ve bellekten onu atar. using içerisine yazdığımız nesneler using bitince anında bellekten atılır. 
            //using; perfonmans açısından ekliyoruz. belleği hızlıca temizleme.
            //using; IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity); //veri kaynağını ilişkilendirme. referansı yakalamak.
                updatedEntity.State = EntityState.Modified; //güncellenecek nesne.
                context.SaveChanges(); //ekleme işlemi.
            }
        }
    }
}