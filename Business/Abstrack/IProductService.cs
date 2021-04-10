using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    //IProductService; iş katmanında kullanacağımız servis operasyonları
    public interface IProductService
    {
        List<Product> GetAll(); //hepsini getir.
        List<Product> GetAllByCategoryId(int id); //CategoryId'ye göre getir.
        List<Product> GetByUnitPrice(decimal min, decimal max); //şu fiyat aralığında olan ürünleri getir.  
    }
}
