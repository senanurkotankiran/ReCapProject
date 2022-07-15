# RentACar -- Araba Kiralama Sistemi
Bu projede araba kiralama sistemi oluşturulmaktadır.Güncellenmeye devam eden projedir.
Bu zamana kadar yapılanlar;
* Entity framework yapısı oluşturuldu.(Guncellenmeye acık)
* Örnek servis olarak GetCarsByBrandId , GetCarsByColorId servislerini yazıldı.
* Sisteme yeni araba eklendiğinde aşağıdaki kurallara göre çalıştırıldı:

      **Araba ismi minimum 2 karakter olmalıdır
      **Araba günlük fiyatı 0'dan büyük olmalıdır.
      
* Temel islemler icin Core katmanı oluturuldu.
* CRUD operasyonlari iyilestirildi.
* Arabalar su bilgiler olacak sekilde listelendi. CarName, BrandName, ColorName, DailyPrice. (Dto olusturulup 3 tablo join edildi)
* Arabanın kiralanma bilgisini tutan tablo oluşturuldu. Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.
* Arabayı kiralama imkanını kodlandı. Rental-->Add
* Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.

