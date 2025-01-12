using System;

public class OgretimGorevlisi : Kisi
{
    public string Bolum { get; set; }

    public override void BilgiGoster()
    {
        base.BilgiGoster();
        Console.WriteLine($"Bölüm: {Bolum}");
    }
}
