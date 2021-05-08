using Business.Abstrack;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  //attribute
    //attribute; bir class ile ilgili bilgi verme, onu imzalama yöntemidir.
    public class ProductsController : ControllerBase
    {
        //IoC Container -- Inversion of Control (Değişimin kontrolü)


        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")] // ("getall"); isim vermek demek. aynı isimde birden çok fonksiyon olursa karışmasını önlüyoruz.
        public IActionResult GetAll()
        {   
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")] // ("getbyid"); isim vermek demek. aynı isimde birden çok fonksiyon olursa karışmasını önlüyoruz.
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")] // ("add"); isim vermek demek. aynı isimde birden çok fonksiyon olursa karışmasını önlüyoruz.
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
