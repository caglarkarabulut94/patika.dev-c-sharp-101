using System.Globalization;
using System.Xml.Linq;
string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   01-degiskenler    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("01-degiskenler");
Console.WriteLine(title);


string baslik01 = @"
---------------------------------------------------------------------------------------------------------
                                            String İfadeler                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik01}\n");

Console.WriteLine("ismizini girin:");

string isim = Console.ReadLine();

while (string.IsNullOrWhiteSpace(isim))
{
    Console.WriteLine("Boş bir değer girdiniz. Lütfen tekrar giriniz:");
    isim = Console.ReadLine();
}

Console.WriteLine($"merhaba {isim}");


string baslik02 = @"
---------------------------------------------------------------------------------------------------------
                                            İnteger İfadeler                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik02}");

Console.WriteLine("sırayla iki tamsayı girin:");
int sayi1 = int.Parse(Console.ReadLine()), sayi2 = int.Parse(Console.ReadLine());

Console.WriteLine("girdiğiniz sayılar: {0} ve {1}", sayi1, sayi2); // index vererek değişkenleri yazma yöntemi

Console.WriteLine($"çarpımları: {Convert.ToString(sayi1 * sayi2)}");

string sayi5 = "20";
Console.WriteLine($"string '20' to int: {int.Parse(sayi5)}");  // string sayıyı integer a çevirme int.Parse(degisken) veya Convert.ToInt32(degisken)




string baslik03 = @"
---------------------------------------------------------------------------------------------------------
                                    Float, Double, Decimal İfadeler                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik03}\n");

float piFlo = 22.0f / 7.0f;  // Float veri tipine direkt değer verirken değerin sonuna 'f' harfi koyulur.
Console.WriteLine($"Float [,6 basamak] türünde  22 / 7: {piFlo}");  // virgülden sonra 6 basamak verir

double piDob = 22.0d / 7.0d;  // Double veri tipine direkt değer verirken değerin sonuna 'f' harfi koyulur veya sadece noktalı şeklinde yazılır.
Console.WriteLine($"Double [,15 basamak] türünde 22 / 7: {piDob}");  // virgülden sonra 15 basamak verir

decimal piDec;
piDec = 22.0m / 7m;    // decimal veri tipine direkt değer verirken değerin sonuna 'm' harfi koyulur.
Console.WriteLine($"Decimal [,28 basamak] türünde 22 / 7: {piDec}");  // virgülden sonra 28 basamak verir




string baslik04 = @"
---------------------------------------------------------------------------------------------------------
                                            Para Dönüşümleri                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik04}\n");

decimal para = 123456789.12345m;

Console.WriteLine(para.ToString("C", CultureInfo.CurrentCulture)); // C: Currency Format Specifier-Para Birimi Biçim Belirleyicisi. Lokasyona göre para birimini ekler.

Console.WriteLine(para.ToString("C3", CultureInfo.CurrentCulture)); // ondalık kısım 3 tane 

Console.WriteLine(para.ToString("C5", CultureInfo.CreateSpecificCulture("en-US"))); // ondalık kısım 5 tane ve amerika formatında $



string baslik05 = @"
---------------------------------------------------------------------------------------------------------
                                            Boolean İfadeler                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik05}\n");

bool b1 = 10 < 3, b2 = 10 > 3; // sadece true veya false değeri alır
Console.WriteLine($"Boolean türünde 10 < 3 : {b1}");
Console.WriteLine($"Boolean türünde 10 > 3 : {b2}");



string baslik06 = @"
---------------------------------------------------------------------------------------------------------
                                            Object İfadeler                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik06}\n");

object sayiObj = 10, isimObj = " Çağlar ", boolObj = 10 > 3; // değişkene ilk verdiğiniz değerin türünü alır.
Console.WriteLine($" İnteger değer:   {sayiObj}  \n String değer: {isimObj} \n Boolean değer: {boolObj}");



string baslik07 = @"
---------------------------------------------------------------------------------------------------------
                                            DateTime İfadeler                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik07}\n");

DateTime tarih = DateTime.Now;
int saat = DateTime.Now.Hour;   // Saat Bilgisi İnterger olarak döner. 12:56 ise sadece 12 döner.
Console.WriteLine($"sadece saat [int türünden]: {saat}");


Console.WriteLine($"şuanki tarih: {tarih}");
Console.WriteLine($"şuanki tarih yerel gösterim ile: {tarih.ToString(CultureInfo.InvariantCulture)} ");  // yerel gösterim ile
Console.WriteLine($"sadece yıl: {tarih.ToString("yyyy")}");
Console.WriteLine($"ay gün yıl: {tarih.ToString("dd.MM.yyyy")}");
Console.WriteLine($"ayırıcı ile: {tarih.ToString("MM'/'dd'/'yyyy")}");
Console.WriteLine($"saat: {tarih.ToString("HH.mm")}");

// Tarihlerle ilgili karşılaştırma yapmak için
Console.WriteLine("\n\n\n");

if (tarih.Hour < 12)  // Saat Bilgisi İnterger olarak döner. 12:56 ise sadece 12 döner.
{
    Console.WriteLine("Günaydın");
}

if (tarih.Hour > 12)
{
    Console.WriteLine("İyi Akşamlar");
}





Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();
