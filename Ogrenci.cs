using System;

public class Ogrenci : Kisi
{
    public int OgrenciNo { get; set; }

    public override void BilgiGoster()
    {
        base.BilgiGoster();
        Console.WriteLine($"Öğrenci No: {OgrenciNo}");
    }
}
