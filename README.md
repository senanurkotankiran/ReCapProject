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
* WebAPI katmanını kuruldu.
* Postmanla test edildi.
* Autofac desteği eklendi.
* FluentValidation desteği eklendi.
* AOP desteği eklendi.
* ValidationAspect eklendi
* Projeye CarImages yapisi asagidaki kurallara gore yuklendi

          * CarImages (Araba Resimleri) tablosu oluşturunuz. (Id,CarId,ImagePath,Date) Bir arabanın birden fazla resmi olabilir.
          * Api üzerinden arabaya resim ekleyecek sistemi yazınız.
          * Resimler projeniz içerisinde bir klasörde tutulacaktır. Resimler yüklendiği isimle değil, kendi vereceğiniz GUID ile dosyalanacaktır.
          * Resim silme, güncelleme yetenekleri ekleyiniz.
          * Bir arabanın en fazla 5 resmi olabilir.
          * Resmin eklendiği tarih sistem tarafından atanacaktır.
          * Bir arabaya ait resimleri listeleme imkanı oluşturunuz. (Liste)
          * Eğer bir arabaya ait resim yoksa, default bir resim gösteriniz. Bu resim şirket logonuz olabilir. (Tek elemanlı liste)
