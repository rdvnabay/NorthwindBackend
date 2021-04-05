using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string AddedProduct = "Ürün başarıyla eklendi";
        public static string UpdatedProduct = "Ürün başarıyla güncellendi";
        public static string DeletedProduct = "Ürün başarıyla silindi";

        public static string AddedCategory = "Kategori başarıyla eklendi";
        public static string UpdatedCategory = "Kategori başarıyla güncellendi";
        public static string DeletedCategory = "Kategori başarıyla silindi";

        public static string UserNotFound = "Böyle bir kullanıcı bulunamadı";
        public static string PasswordError = "Şifrenizi hatalı girdiniz";
        public static string SuccessfulLogin = "Giriş başarılız";

        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";

        public static string UserRegistered = "kayıt başarılı";

        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
