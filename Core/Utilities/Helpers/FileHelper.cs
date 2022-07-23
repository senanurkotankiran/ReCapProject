using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper : IFileHelper
    {

        public void Delete(string filePath)
        {
            if (File.Exists(filePath))//parametreden gelen adretse öyle bir dosya var mı yok mu?
            {
                File.Delete(filePath);//dosya var ise bulunduğu yerden sil.
            }
        }

        public string Update(IFormFile file, string filePath, string root) //file = image
        {
            if (File.Exists(filePath))//parametreden gelen adreste öyle bir dosya var mı yok mu?
            {
                File.Delete(filePath);//dosya var ise bulunduğu yerden sil.
            }
            return Upload(file, root);//eski dosya silindikten sonra yerine geçecek dosya için upload metoduna yeni dosya ve kayıt edileceği adres parametre olarak döndürülür.
        }

        public string Upload(IFormFile file, string root)
        {
            if (file.Length > 0) //dosya gönderildi mi gönderilmedi mi?
            {
                if (!Directory.Exists(root))//Upload methodumun parametresi olan root CarManager'den gelir. //root yoksa
                {                           //dosyanın kaydedileceği adres dizini var mı, varsa bloktan ayrıl yoksa dosyanın kayıt edileceği dizini oluştur.

                    Directory.CreateDirectory(root);
                }
                string extension = Path.GetExtension(file.FileName);//seçmiş olduğumuz dosya uzantısını elde ediyoruz, rasgele id için ayırdık
                string guid = GuidHelper.CreateGuid(); //GuidHelper klasörünü incele
                string filePath = guid + extension; //Dosyanın adını ve uzantısını yan yana getirdim örn resim dosyası için .jpg

                using (FileStream fileStream = File.Create(root + filePath)) //FileStream class'ı örneği oluşturduk, belirtilen yolda dosya oluşturdum/üzerine yazdım(root+newPath)=>oluşturulacak dsya adı ve yolu
                {
                    //root'a yeni dosya ekledi.
                    file.CopyTo(fileStream);//Yukarıdan gelen IFromFile türündeki file dosyasının nereye kopyalanacağını söyledik.
                    fileStream.Flush();//resmi arabellekten siler.
                    return filePath;//dosya adını tam gönderiyoruz sebebi sqlservere dosya eklenirken adı ile eklenmesi için
                }

            }
            return null;
        }
    }
}
