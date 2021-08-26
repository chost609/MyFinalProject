using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun Eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime = "Sistem Bakimda";
        public static string ProductsListed = "Urunler Listelendi";
        public static string UnitPriceInvalid = "Fiyat gecersiz";
        public static string ProductCountOfCategoryError = "En fazla 10 urun eklenebilir";

        public static string ProductNameAlreadyExists = "Urun ismi ayni olamaz";

        public static string CategoryLimitExceded = "Kategori limiti asildigi icin yeni urun eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yoktur.";
        public static string UserRegistered = "Kullanici eklendi";
        public static string UserNotFound = "Kullanici Bulunamadi";
        public static string SuccessfulLogin = "Basarili Giris";
        public static string PasswordError = "Parola Hatasi";
        public static string UserAlreadyExists = "Kullanici Mevcut";
        public static string AccessTokenCreated = "Token olusturuldu";
    }
}
