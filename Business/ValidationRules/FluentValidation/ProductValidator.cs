using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        //bu kurallar bir constructor'ın içine yazılır.
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty(); //ProductName'i boş geçilemez.
            RuleFor(p => p.ProductName).MinimumLength(2); //ProductName'i minimum 2 karakter olmalıdır.
            RuleFor(p => p.UnitPrice).NotEmpty();//UnitPrice'de boş geçilemez.
            RuleFor(p => p.UnitPrice).GreaterThan(0); //UnitPrice 0'dan büyük olmalıdır.
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1); //UnitPrice'nin başlangıç fiyatı 10 olmalı ama CategoryId'si 1 olunca.
            //Olmayan bir kuralı biz yazabiliriz.
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı."); //ProductName A harfi ile başlamalı.
            //WithMessage(); Kendi hata mesajını yazıyorsun. Kullanıcının gördüğü hata mesajını.
        }

        private bool StartWithA(string arg) //kendi kuralımız. ture ve false döndürür.
        {
            return arg.StartsWith("A");
        }
    }
}
