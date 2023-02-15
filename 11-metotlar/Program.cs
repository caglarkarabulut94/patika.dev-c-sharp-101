class Program
{
    static void Main(string[] args)
    {



        string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   11-metotlar    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
        Console.Title = ("11-metotlar");
        Console.WriteLine(title);








        //erisim_belirteci geri_donustipi metod_adi(parametreListesi/arguman)
        //{
        //komutlar;
        //return;
        //}

        int a = 2;
        int b = 3;
        Console.WriteLine($"Console.WriteLine ile a+b: {a + b}  \n");

        int sonuc = Topla(a, b);  // aynı class içindeki topla metotuna a ve b yi gönderip gelen değeri sonuc depişkenine atıyoruz.
        Console.WriteLine($"topla metotu ile a+b: {sonuc} \n");

        Metotlar metotlar = new Metotlar();  // metotlar classının örneiğini alıyoruz.
        metotlar.EkranaYazdir($"sonuc: {sonuc}"); // metotlar classındaki EkranaYazdir metotuna sonuc değişkenini gönderiyoruz.
                                                  // bu metot public olduğu için ulaşabiliyoruz.

        int sonuc2 = metotlar.ArttirVeTopla(ref a, ref b);
        metotlar.EkranaYazdir($"ArttirVeTopla metotundan dönen: {sonuc2}");
        metotlar.EkranaYazdir($"\n a: {a}\n b: {b}  ");  // a:3 b:4 dönecek çünkü ArttirVeTopla metotunu kullanırken ref kullanarak bellekteki değişenlerin değerlerini değiştirdik.



        Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
        Console.ReadKey();
    }

    private static int Topla(int a, int b)  // Mai metotu varsayılan olarak static olduğu için bu classın içindeki metotlara static vermemiz gerekiyor.
    {
        return (a + b);
    }
}

class Metotlar  // metotlar için yeni bir class oluşturduk
{

    public void EkranaYazdir(string veri)  // void yani return geri dönüşü olmayan metot
    {
        Console.WriteLine($"EkranaYazdir:  {veri} \n");
    }

    public int ArttirVeTopla(ref int deger1, ref int deger2)  // ref verdiğimizde referans verilen değişendeki değişiklik kalıcı hale gelir. ana değişken de değişir.
    {
        deger1++;
        deger2++;
        return (deger1 + deger2);
    }

}