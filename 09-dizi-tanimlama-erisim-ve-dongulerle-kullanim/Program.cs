
string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   09-dizi-tanimlama-erisim-ve-dongulerle-kullanim    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("09-dizi-tanimlama-erisim-ve-dongulerle-kullanim");
Console.WriteLine(title);


//Dizi Tanımlama
string[] renkler = new string[5]; //Atama yapmadan, yalnızca 5 elemanlı bir dizi tanımlaması. Bellekte yer ayırıp atama yapmıyoruz.

string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

int[] dizi; //instance vermeden, bellekte yer ayırmadan tanımlıyoruz.
dizi = new int[5]; //instance verip bellekte yer ayırıyoruz fakat atama yapmıyoruz.


//Dizilere değer atama ve erişim

renkler[0] = "Mavi"; //renkler isimli dizinin 0 index numaralı (yani ilk elemanına) elemanına "Mavi" değerini atıyoruz.
dizi[3] = 10;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);




string baslik01 = @"
---------------------------------------------------------------------------------------------------------
                Klavyeden girilen n tane sayının ortalamasını hesaplayan program                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik01}\n");
//Döngülerde dizi kullanımı
Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.WriteLine("Lütfen {0}. sayıyı giriniz:", i + 1);
    //Console.WriteLine("Lütfen " + (i + 1) + ". sayıyı giriniz:"); // bu şekilde de yazabilirdik. aynısı olur.
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (int sayi in sayiDizisi)
{
    toplam += sayi;
}
Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);





Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();