using System.Globalization;
string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   03-tip-donusumleri    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("03-tip-donusumleri");
Console.WriteLine(title);



string baslik01 = @"
---------------------------------------------------------------------------------------------------------
                         Implicit Conversion (Kapalı, Örtülü, Bilinçsiz Dönüşüm.)                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik01}\n");
//sayısal değişkenler - en küçük kaparsiteliden büyüterek gidiyoruz.
byte a = 4;
sbyte b = 50;
short c = 40;

int d = a + b + c;

Console.WriteLine("int d: " + d);

long h = d;
Console.WriteLine("long h: " + h);

float i = h;
Console.WriteLine("float i: " + i);

// metinsel değişkenler
string e = "caglarkarabulu";
char f = 't';
object g = e + f + d;

Console.WriteLine($"object g: {g}");



string baslik02 = @"
---------------------------------------------------------------------------------------------------------
       Explicit Conversion (Açık, Bilinçli Dönüşüm. C#'ın yapamadığı bizim yaptığımız dönüşümler.)                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik02}\n");
int x = 4;
Console.WriteLine($"int x: {x}");
byte y = (byte)x; //Integer türdeki değişkeni byte türüne cast ediyoruz.
Console.WriteLine($"int ten byte e dönüşüm  - y: {y}");


float w = 10.38686786f;
Console.WriteLine($"float w: {w}");
byte v = (byte)w; //Float türü, byte türüne explicit yöntemle cast ediyoruz.
Console.WriteLine($"float tan byte e dönüşüm - v: {v}"); // çıktı: 10




string baslik03 = @"
---------------------------------------------------------------------------------------------------------
                                            ToString Metodu                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik03}\n");
int xx = 6;
string yy = xx.ToString();
Console.WriteLine($"int den string e - yy: {yy}");

string zz = 12.58445985f.ToString();
float fl = 12.58445985f;
Console.WriteLine($"float fl: {fl}");
Console.WriteLine($"12.58445985f den string e dönüşüm - zz: {zz}");




string baslik04 = @"
---------------------------------------------------------------------------------------------------------
                                            Para Dönüşümleri                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik04}\n");
decimal para = 123456789.12345m;

Console.WriteLine(para.ToString("C", CultureInfo.CurrentCulture)); // C: Currency Format Specifier-Para Birimi Biçim Belirleyicisi. Lokasyona göre para birimini ekler.

Console.WriteLine(para.ToString("C3", CultureInfo.CurrentCulture)); // ondalık kısım 3 tane 

Console.WriteLine(para.ToString("C5", CultureInfo.CreateSpecificCulture("en-US"))); // ondalık kısım 5 tane ve amerika formatında $

Console.WriteLine($"Toplam Tutar: {para.ToString("C5", CultureInfo.CurrentCulture)}");

string baslik05 = @"
---------------------------------------------------------------------------------------------------------
                                                Convert                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik05}\n");
string string1 = "10", string2 = "20";
int sayi1, sayi2, Toplam;

sayi1 = Convert.ToInt32(string1);
sayi2 = Convert.ToInt32(string2);
Toplam = sayi1 + sayi2;
Console.WriteLine($"Toplam: {Toplam}");




string baslik06 = @"
---------------------------------------------------------------------------------------------------------
                                                  Parse                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik06}\n");

ParseMethod();  // metotu çağırıyoruz. 
static void ParseMethod()  // metotu tanımlıyoruz.
{
    string metin1 = "3";
    string metin2 = "3.141592653589793238462643383279";
    string metin3 = "3.141592653589793238462643383279";

    int int1;
    double double1;
    float float1;

    int1 = Int32.Parse(metin1);
    double1 = Double.Parse(metin2);
    float1 = float.Parse(metin3);
    // decimal hata veriyor

    Console.WriteLine($"int1: {int1}");
    Console.WriteLine($"double1: {double1}");
    Console.WriteLine($"float1: {float1}");
}


Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();
