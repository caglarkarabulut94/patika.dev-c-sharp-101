string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   12-metotlar-overloading    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("12-metotlar-overloading");
Console.WriteLine(title);



string sayi = "999";
bool sonuc = int.TryParse(sayi, out int outSayi);  // sayi değişkenindeki değeri integer a çevirmeye çalışıyoruz. 
                                                   // bu metotun çıktısı boolean tipinde döner.
if (sonuc)
    Console.WriteLine($"Çevirme Başarılı! \n Çevrilen sayının 1 fazlası: {outSayi + 1}"); // çevirme başarılı olmasaydı integer olmayacağı için toplama yapamayazdık.
else
    Console.WriteLine("Çevirme Başarısız oldu. \n");




Metotlar metotlar = new Metotlar();
metotlar.Topla(4, 5, out int toplam);
Console.WriteLine(toplam);




//metotlara Aşırı Yükleme
int ifade = 999;

metotlar.EkranaYazdir(ifade);
metotlar.EkranaYazdir("Çağlar ", "KARABULUT");
//metot imzası metotadı + parametre sayısı + parametre tipi




Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();




class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }



    // overloading 
    // ekrana bişey yazdırmak için kullanacağımız bir metot için: 
    // integer için ayrı isimle 
    // string için ayrı isimle metot açmak yerine overloading yaparak kullanıyoruz.
    // aynı isimle yazıyoruz. gönderdiğimiz verii tipi ilgili metota kendi gidiyor.


    public void EkranaYazdir(string veri) // EkranaYazdır metotuna 1 tane string değer yollanınca çalışacak 
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri) // EkranaYazdır metotuna integer veri yollanınca çalışacak
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2) // EkranaYazdır metotuna 2 tane string değer yollanınca çalışacak 
    {
        Console.WriteLine(veri1 + veri2);
    }
}
