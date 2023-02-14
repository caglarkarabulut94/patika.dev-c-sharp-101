string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   07-for-break-continue    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("07-for-break-continue");
Console.WriteLine(title);



string baslik01 = @"
---------------------------------------------------------------------------------------------------------
                                            for                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik01}\n");
//Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdırır.



Console.WriteLine("\nKaça kadar tek sayılar yazdırılacak: ");
int sayac = int.Parse(Console.ReadLine());


for (int i = 1; i <= sayac; i++)
{
    Console.Write((i % 2 == 1 ? (i == sayac || i == sayac - 1 ? i + "." : i + ", ") : ""));
}




Console.WriteLine("\n\n\n\n 1 ile 1000 arasındaki tek ve çift sayıların kendi içerisinde toplamı");
int tekToplam = 0;
int ciftToplam = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 1)
    {
        tekToplam += i;//Tek sayı.
    }
    else
    {
        ciftToplam += i;//Çift sayı.
    }
}

Console.WriteLine($"Tek sayıların toplamı: {tekToplam}");
Console.WriteLine($"Çift sayıların toplamı: {ciftToplam}");





string baslik02 = @"
---------------------------------------------------------------------------------------------------------
                                            continue                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik02}\n");
for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        continue;
        //sayı eğer 4 ise, döngüyü burada durdurup bir sonraki aşamadan devam ettirecek.
        //Yani aşağıdaki hiç bir kod çalışmayacak.        
    }
    Console.WriteLine($"bu kod i=4 koşuluna girince yazılmayacak. i: {i}");
}


string baslik03 = @"
---------------------------------------------------------------------------------------------------------
                                            break                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik03}\n");

for (int i = 1; i < 10; i++)
{
    if (i == 4)
    {
        break;
        //Sayı 4 ise, döngüyü kıracak. For döngüsü parantezlerinin bitiminden Program devam edecek.
    }
    Console.WriteLine("bu kod ekrana i=4 olduktan sonra yazılmayacak, i: {i}");
}






Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();
