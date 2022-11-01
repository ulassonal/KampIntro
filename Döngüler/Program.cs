// See https://aka.ms/new-console-template for more information

string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";

//array  - dizi

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
"Programlamaya Başlangıç İçin Temel Kurs",
    "java",
"phyton"};


for (int i = 0; i < kurslar.Length ; i++)
{
    Console.WriteLine(kurslar[i]);
}

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("Sayfa Sonu");
 