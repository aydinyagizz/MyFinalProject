using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrack
{  
    //Product ile ilgili veritabanında yapacağım operasyonları içeren interface
    public interface IProductDal
    {
        //interface metotları default public'dir.
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);

    } 
}
