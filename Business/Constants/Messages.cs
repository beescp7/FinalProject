using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintemamceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "kategori sayısı 10 u gecemez ";
        public static string ProductNameAlreaddyExists="Bu isimde zaten ürün var ";
        public static string CategoryLimitExceded="category limitin doldu kirvem";
    }
}
