// Değişkenler camel Casing isimlendirilir.

int yas;
yas = 28;  // assignment - set - atama işlemi.

Console.WriteLine(yas); // read - okuma işlemi.

char karakter = 's';

string isim = "sertan";

// string aslında karakterlerden oluşan  bir dizi.


Console.WriteLine("Lütfen adınızı yazınız.");
isim = Console.ReadLine(); // Assignment

Console.WriteLine("Değişken içerisinde veri ---> " + isim); // Read

Console.WriteLine("--------------------");

Console.WriteLine("Lütfen yaşınızı giriniz.");
int yas2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kişinin yaşı -> " + yas2);

Console.WriteLine($"Kişinin yaşı -> {yas2}");

Console.WriteLine("Kişinin yaşı -> {0} - Adı -> {1} ",yas2,isim);