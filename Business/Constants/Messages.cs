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
        public static string CarCountOfBrandError = "Markada limiti hatası";
        public static string AddSingular = "eklendi.";
        public static string UpdateSingular = " güncellendi.";
        public static string DeleteSingular = " silindi.";
        public static string NotExist = "bulunamadı";
        public static string InvalidFileExtension = "Invalid file extension.";
        public static string ImageNumberLimitExceeded = "The image limit for this car is full and new images cannot be added.";
        internal static string CarUpdated;
    }
}
