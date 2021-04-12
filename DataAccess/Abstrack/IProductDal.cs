using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrack
{  
    //Product ile ilgili veritabanında yapacağım operasyonları içeren interface
    public interface IProductDal:IEntityRepository<Product>
    {
        //interface metotları default public'dir.

        List<ProductDetailDto> GetProductDetails(); //ürünün detaylarını getirir.
    } 
}
