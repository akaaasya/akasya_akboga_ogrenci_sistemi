using System;
using System.IO;
using Newtonsoft.Json;

namespace AkasyaOgrenciDersYonetim
{
    class Program
    {
        static void Main(string[] args)
        {
            // JSON dosyasını okuma
            var jsonString = File.ReadAllText(@"C:\Users\Emre\Desktop\C# Windows Form Projeleri\AkasyaOgrenciDersYonetim\ders.json");

            var ders = JsonConvert.DeserializeObject<Ders>(jsonString);

            // Ders bilgilerini gösterme
            ders.BilgileriGoster();

            // Yeni öğrenci ekleme
            Ogrenci yeniOgrenci = new Ogrenci
            {
                Isim = "Ali Can",
                Yas = 19,
                OgrenciNo = 11223
            };
            ders.OgrenciKaydet(yeniOgrenci);

            // Güncellenmiş ders bilgilerini gösterme
            ders.BilgileriGoster();

            // JSON dosyasını güncelleme
            var updatedJson = JsonConvert.SerializeObject(ders, Formatting.Indented);
            File.WriteAllText("ders.json", updatedJson);
        }
    }
    
}
