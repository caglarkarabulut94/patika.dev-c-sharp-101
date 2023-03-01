using System.Collections;

string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   14-odev1    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("14-odev1");
Console.WriteLine(title);






string baslik01 = @"
---------------------------------------------------------------------------------------------------------
soru 1 
 Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik01}\n");


Console.WriteLine($"kaç tane sayı gireceksiniz:");
int n = int.Parse(Console.ReadLine());

int[] sayilar = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"{i + 1}. sayıyı girin:");
    sayilar[i] = int.Parse(Console.ReadLine());
}

Metotlar metotlar = new();
ArrayList ciftSayilar = new ArrayList();

for (int i = 0; i < n; i++)
{
    if (metotlar.ciftMi(sayilar[i]))
    {
        ciftSayilar.Add(sayilar[i]);
    }
}

Console.WriteLine("\nÇift sayılar: " + string.Join(", ", ciftSayilar.ToArray()));





string baslik02 = @"
---------------------------------------------------------------------------------------------------------
soru 2 
 Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik02}\n");

Console.WriteLine($"\nKaç adet sayı gireceksiniz?:");
int adet = int.Parse(Console.ReadLine());

Console.WriteLine($"\nGirdiğiniz sayılar hangi sayıya bölünsün?:");
int bolen = int.Parse(Console.ReadLine());




int[] sayilar2 = new int[adet];
for (int i = 0; i < adet; i++)
{
    Console.Write($"{i + 1}. sayıyı girin:");
    sayilar2[i] = int.Parse(Console.ReadLine());
}

ArrayList bolunebilenSayilar = new ArrayList();

for (int i = 0; i < sayilar2.Length; i++)
{
    if (metotlar.bolme(sayilar2[i], bolen))
    {
        bolunebilenSayilar.Add(sayilar2[i]);
    }
}

Console.WriteLine("\n Girdiğiniz sayılar arasında " + bolen + " sayısına tam bölünebilen sayılar: " + string.Join(", ", bolunebilenSayilar.ToArray()));






string baslik03 = @"
---------------------------------------------------------------------------------------------------------
soru 3 
 Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.                                              
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik03}\n");

Console.WriteLine($"\nKaç tane kelime gireceksiniz?:");
int kelimeAdeti = int.Parse(Console.ReadLine());

string[] kelimeler = new string[kelimeAdeti];
for (int i = 0; i < kelimeAdeti; i++)
{
    Console.Write($"{i + 1}. kelimeyi girin:");
    kelimeler[i] = Console.ReadLine();
}


foreach (var item in kelimeler.Reverse())
    Console.WriteLine(item);







string baslik04 = @"
---------------------------------------------------------------------------------------------------------
soru 3 
 Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
Cümledeki toplam kelime ve harf sayısını console'a yazdırın.                                             
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik04}\n");

string cumle = Console.ReadLine();

string[] cumledekiKelimeler = cumle.Split(" ");

Console.WriteLine("Cümlenizdeki toplam harf sayısı: {0}, kelime sayısı: {1}", cumle.Length, cumledekiKelimeler.Length);








Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();

public class Metotlar
{

    public bool ciftMi(int sayi)
    {
        if (sayi % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public bool bolme(int bolunen, int bolen)
    {
        if (bolunen % bolen == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}














