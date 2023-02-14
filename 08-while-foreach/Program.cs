
string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   08-while-foreach    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("08-while-foreach");
Console.WriteLine(title);



string baslik01 = @"
---------------------------------------------------------------------------------------------------------
                                            While                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik01}\n");


Console.WriteLine("1'den başlayarak console'dan girilen sayıya kadar (sayı dahil) olan sayıların ortalaması");
Console.WriteLine("Lütfen bir sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi)
{
    //Console.WriteLine("toplam: " + toplam + " + " + "sayac: " + sayac + " = " + "toplam:" + (toplam + sayac));
    Console.WriteLine($"toplam({toplam}) + sayac({sayac}) = toplam:{toplam + sayac}");
    toplam += sayac;
    sayac++;
}
Console.WriteLine($"1 den {sayi} a kadar olan sayıların ortalaması:  {toplam / sayi}");




Console.WriteLine("\n\n\n\n\n\n\n'a' dan 'z' ye (z dahil) kadar tüm harfler");

char character = 'a';
while (character <= 'z')
{
    Console.Write(character + " ");
    character++;
}


string baslik02 = @"
---------------------------------------------------------------------------------------------------------
                                            Foreach                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik02}\n");

string[] arabalar = {
    "BMW",
    "FORD",
    "TOYOTA",
    "NİSSAN"
};


foreach (var araba in arabalar)  // dizinin tüm elemanlarını ekrana yazdırır
{
    Console.WriteLine(araba);
}








Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();







