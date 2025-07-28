Console.WriteLine("KULLANICI DOĞRULAMA");

Console.Write("Ad Soyad: ");
string calısan  = Console.ReadLine();

Console.Write("Şifre giriniz: ");
string password = Console.ReadLine();

string dogrusifre = "Malatya44";

if (dogrusifre == password)
{
    Console.WriteLine("Hoşgeldin Yönetici :) ");
}

if (dogrusifre != password)
{
    Console.WriteLine("Hatalı giriş");
}