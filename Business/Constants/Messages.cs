using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //sürekli new'lememek için static yaptık.
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInValid = "Ürün İsmi Geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 Ürün Bulunabilir.";
        public static string ProductNameAlreadyExists = "Bu İsimde Zaten Başka Bir Ürün Var.";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldığı İçin Yeni Ürün Eklenemiyor.";
    }
}
