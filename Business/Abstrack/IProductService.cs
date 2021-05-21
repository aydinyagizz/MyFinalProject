using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    //IProductService; iş katmanında kullanacağımız servis operasyonları
    public interface IProductService
    {
        //data olanları IDataResult, data olmayanları yani voidleri IResult dedik.
        IDataResult<List<Product>> GetAll(); //hepsini getir.
        IDataResult<List<Product>> GetAllByCategoryId(int id); //CategoryId'ye göre getir.
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max); //şu fiyat aralığında olan ürünleri getir.  
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId); //sadece product döndürür. tek başına bir ürün döndürür.
        IResult Add(Product product); //yeni ürün ekleme.
        IResult Update(Product product); //ürün güncelleme.
    }
}
