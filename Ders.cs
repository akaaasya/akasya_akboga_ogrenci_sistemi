using System;
using System.Collections.Generic;

public class Ders
{
    public string DersAdi { get; set; }
    public int Kredi { get; set; }
    public OgretimGorevlisi OgretimGorevlisi { get; set; }
    public List<Ogrenci> KayitliOgrenciler { get; set; }

    public Ders(string dersAdi, int kredi, OgretimGorevlisi ogretimGorevlisi)
    {
        DersAdi = dersAdi;
        Kredi = kredi;
        OgretimGorevlisi = ogretimGorevlisi;
        KayitliOgrenciler = new List<Ogrenci>();
    }

    public void OgrenciKaydet(Ogrenci ogrenci)
    {
        KayitliOgrenciler.Add(ogrenci);
    }

    public void BilgileriGoster()
    {
        Console.WriteLine($"Ders Adı: {DersAdi}, Kredi: {Kredi}");
        Console.WriteLine($"Öğretim Görevlisi: {OgretimGorevlisi.Isim} ({OgretimGorevlisi.Bolum})");
        Console.WriteLine("Kayıtlı Öğrenciler:");
        foreach (var ogrenci in KayitliOgrenciler)
        {
            Console.WriteLine($"{ogrenci.Isim}, Öğrenci No: {ogrenci.OgrenciNo}");
        }
    }
}
