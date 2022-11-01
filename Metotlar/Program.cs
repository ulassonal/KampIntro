
using Metotlar;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";
urun1.StokAdedi = 500;

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";
urun2.StokAdedi = 200;

Urun[] urunler = new Urun[] {urun1,urun2};

foreach (var Urun in urunler)
{
    Console.WriteLine(Urun.Adi);
    Console.WriteLine(Urun.Fiyati);
    Console.WriteLine(Urun.Aciklama);
    Console.WriteLine("----------------------");
}
Console.WriteLine("------------Metotlar--------------------------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);
