using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Araba Mesajları
        public static string MaintenanceTime = "Sistem bakımda!";

        public static string CarAdded = "Araç Başarıyla Eklendi.";
        public static string CarNameInvalid = "Araç ismi geçersiz!";
        public static string CarsListed = "Araç listelendi!";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Araba  silindi.";
        public static string CarIdListed = "Araba id'ye göre  listelendi";
        public static string CarsByColorId = "Arabalar renk id'sine göre  listelendi";
        public static string CarsByBrandId = "Arabalar marka id'sine göre  listelendi";
        public static string CarPriceInvalid = "Günlük fiyat değeri 0'dan büyük olmalıdır. Girdiğiniz değer geçersiz.";
        //Marka Mesajları
        public static string BrandAdded = "Marka Başarıyla Eklendi.";
        public static string BrandNameInvalid = "Marka ismi minimum uzunluğu 2 karakterden fazla olmalıdır. Girdiğiniz marka ismi geçersiz";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka Güncellendi.";
        public static string BrandListed = "Marka listelendi.";
        public static string BrandUpdate = "Marka güncellendi.";
        public static string BrandIdListed = "Marka id'ye göre  listelendi.";
        //Renk Mesajları
        public static string ColorAdded = "Renk başarıyla eklendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorsListed = "Renkler listelendi.";
        public static string ColorIdListed = "Renk id'ye göre listelendi.";
        public static string ColorUpdated = "Renk güncellendi";
        //Müşteri Mesajları
        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomersListed = "Müşteriler listelendi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerIdListed = "Müşteri id'ye göre listelendi.";
        //Kullanıcı Mesajları
        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserIdListed = "Kullanıcı id'ye göre listelendi.";
        //Kiralama İşlemi Mesajları
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string RentalAdded = "Kiralama işlemi başarılı";
        public static string RentalDelete = "Kiralama işlemi silindi";
        public static string RentalUpdated = "Araç kiralama işlemi güncellendi.";
        public static string RentalListed = "Kiralanabilecek araçlar listelendi.";
        //Fotoğraf Mesajları
        public static string CarImageDeleted = "Araba fotoğrafı silindi.";
        public static string CarImageAdded = "Araç fotoğrafı başarıyla eklendi ";
        public static string CarImagesListed = "Araç fotoğrafları listelendi.";
        public static string CarCheckImageLimited = "Fotoğraf ekleme limitiniz doldu.";

        public static string AuthorizationDenied = "Bu işlemi yapmak için yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifreyi yanlış girdiniz";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Created Token";


    }
}

