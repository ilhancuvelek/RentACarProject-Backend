using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "sistem bakımda";
        public static string CarListed = "Arabalar listelendi";
        public static string CarNameAlreadyExists = "bu isimde zaten başka bir Araba var";
        public static string CategoryLimitedExceded = "kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "yetkiniz yok";
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string PasswordError = "şifre hatalı";
        public static string SuccessfulLogin = "başarılı giriş";
        public static string UserAlreadyExists = "kullanıcı mevcut";
        public static string AccessTokenCreated = "token oluştu";
        internal static string CarUpdated;
    }
}
