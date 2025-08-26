using KitapOrnek;

Kitap[] raf = new Kitap[3];
for (int i = 0; i < raf.Length; i++)
{
    Console.WriteLine("Kitap Adi:");
    string kitapAdi = Console.ReadLine();
    Console.WriteLine("Yazar Adi:");
    string yazarAdi = Console.ReadLine();
    Console.WriteLine("Yil:");
    int yil = int.Parse(Console.ReadLine());
    Console.WriteLine("Fiyat giriniz: ");
    int fiyat = int.Parse(Console.ReadLine()); 

    Kitap kitap = new Kitap();
    kitap.kitapAdi = kitapAdi;
    kitap.yazarAdi = yazarAdi;
    kitap.yil = yil;
    kitap.fiyat = fiyat;

    raf[i] = kitap; 
}
Console.WriteLine("Rafinizdaki kitaplar:");
foreach(var kitap in raf)
{
    Console.WriteLine($"Kitap Adi: {kitap.kitapAdi}, Yazar Adi: {kitap.yazarAdi}, Yil: {kitap.yil}, Fiyat: {kitap.fiyat}");
}