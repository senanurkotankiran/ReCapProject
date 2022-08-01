using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi! ";
        public static string CarNameInValid = "Araba ismi gecersiz! Minimum 2 karakter olmalı ";
        public static string CarDeleted = "Araba silindi!";
        public static string CarUpdated = "Araba güncellendi!";
        public static string CarListed = "Arabalar listelendi!";

        public static string BrandAdded = "Marka eklendi! ";
        public static string BrandDeleted = "Marka silindi!";
        public static string BrandUpdated = "Marka güncellendi!";
        public static string BrandListed = "Markalar listelendi!";

        public static string ColorAdded = "Renk eklendi! ";
        public static string ColorDeleted = "Renk silindi!";
        public static string ColorUpdated = "Renk güncellendi!";
        public static string ColorListed = "Renkler listelendi!";

        public static string UserAdded = "Kullanıcı eklendi! ";
        public static string UserDeleted = "Kullanıcı silindi!";
        public static string UserUpdated = "Kullanıcı güncellendi!";
        public static string UserListed = "Kullanıcılar listelendi!";

        public static string CustomerAdded = "Müşteri eklendi! ";
        public static string CustomerDeleted = "Müşteri silindi!";
        public static string CustomerUpdated = "Müşteri güncellendi!";
        public static string CustomerListed = "Müşteriler listelendi!";

        public static string RentalDateIsNull = "Araba teslim edilmemiştir ";
        public static string RentalAdded = "Araba sipariş bilgisi eklendi ";
        public static string RentalDeleted = "Araba sipariş bilgisi silindi ";
        public static string RentalUpdated = "Araba sipariş bilgisi güncellendi "; 
        public static string RentalListed = "Sipariş bilgilerinin tümü listelendi!";


        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string CarNameAlreadyExists = "Ürün ismi zaten mevcut";
    }
}
