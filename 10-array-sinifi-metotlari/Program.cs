string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   10-array-sinifi-metotlari    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("10-array-sinifi-metotlari");
Console.WriteLine(title);





//Sort 

int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

string baslik01 = @"
---------------------------------------------------------------------------------------------------------
                                              Sırasız Dizi                                             
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik01}\n");

foreach (int sayi in sayiDizisi)
    Console.Write(sayi + "  ");



string baslik02 = @"
---------------------------------------------------------------------------------------------------------
                                           Sıralı Dizi                                              
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik02}\n");

Array.Sort(sayiDizisi);   // sıralama fonksiyonu.
foreach (int sayi in sayiDizisi)
    Console.Write(sayi + "  ");

Console.WriteLine("\n\n sıralayınca index değişir. ilk eleman en küçük eleman olur.");
Console.WriteLine("ilk eleman: " + sayiDizisi[0]);



string baslik03 = @"
---------------------------------------------------------------------------------------------------------
                                             Array Clear                                               
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik03}\n");

//Array.Clear(sayiDizisi); bütün dizeyi sıfırlar.
Array.Clear(sayiDizisi, 2, 2);// 2. indexten başlayarak 2 tane elemanını sıfırlar.
// diziyi sıraladığımız için dizi 3  4  11  12  17  23  72  86 
//yani 11 ve 12 sıfırlanacak.
foreach (int sayi in sayiDizisi)
    Console.WriteLine(sayi);



string baslik04 = @"
---------------------------------------------------------------------------------------------------------
                                      Reverse (Ters Çevirme)                                               
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik04}\n");
Array.Reverse(sayiDizisi);
foreach (int sayi in sayiDizisi)
    Console.WriteLine(sayi);






string baslik05 = @"
---------------------------------------------------------------------------------------------------------
                                    Resize(Yeniden Boyutlandırma)                                             
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik05}\n");

Array.Resize<int>(ref sayiDizisi, 9);//int türünde, sayı dizisini referans alarak 9 elemanlı şekilde yeniden boyutlandırır.
// sayiDizisi[8] = 99;  // 9 elemanlı yaptık. 0 dan başşladığı için son eleman 8 olur.
int say = 0;
foreach (int sayi in sayiDizisi)
    Console.WriteLine($" {++say}. sayı:  {sayi} ");





string baslik06 = @"
---------------------------------------------------------------------------------------------------------
                        Array IndexOf (Verilen eleman varsa, indexini döndürür.)                                             
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik06}\n");

string[] ogrenciler = { "ali", "veli", "ayşe", "ahmet" };
int ayseninIndexi = Array.IndexOf(ogrenciler, "ayşe");
Console.WriteLine($"ayşenin indexi: {ayseninIndexi}"); //Ayşenin kaç numaralı indexte olduğunu döndürür.





Console.WriteLine($"\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();