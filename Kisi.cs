using System;
using AkasyaOgrenciDersYonetim;

public class Kisi : IPerson
{
    public string Isim { get; set; }
    public int Yas { get; set; }

    public virtual void BilgiGoster()
    {
        Console.WriteLine($"İsim: {Isim}, Yaş: {Yas}");
    }
}
