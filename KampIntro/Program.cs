// See https://aka.ms/new-console-template for more information

bool sistemeGirisYapmisMi = true;

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı Ayarlar Butonu");
}
else
{
    Console.WriteLine("Giriş Yap Butonu");
}

double dolarDun = 18.61;
double dolarBugun = 18.61;

if (dolarBugun<dolarDun)
{
    Console.WriteLine("Aşşağı Doğru Ok");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Yukarı Doğru Ok");
}
else
{
    Console.WriteLine("Değişmedi Oku");
}