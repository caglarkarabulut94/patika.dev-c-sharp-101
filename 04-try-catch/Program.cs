string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   04-try-catch    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("04-try-catch");
Console.WriteLine(title);


try
{
    Console.WriteLine("Bir Sayı Giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Girmiş olduğunuz sayı : {sayi}");
}
catch (Exception myException)
{
    Console.WriteLine($"Hata Oluştu ! \n Hata Kodu: [ {myException.Message.ToString()}  ]");
}
finally
{
    Console.WriteLine("Programın sonu.");
}


Console.WriteLine("\n\n\n\n\n\n\n ikinci try catch koduna geçmek için Enter.");
Console.ReadKey();


try
{
    //int a = int.Parse(null);
    //int b = int.Parse("test");
    int c = int.Parse("-200000000000");
}
catch (ArgumentNullException ex)
{   //  ArgumentNullException ex: Boş değer döndüyse
    Console.WriteLine("Boş değer girdiniz.");
    Console.WriteLine($"Hata Kodu: {ex}");
}
catch (FormatException ex)
{    //  Veri Tipi uygun değilse 
    Console.WriteLine("Veri tipi uygun değil.");
    Console.WriteLine($"Hata Kodu: {ex}");
}
catch (OverflowException ex)
{  //  Çok küçük ya da çok büyük bir değerse 
    Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
    Console.WriteLine($"Hata Kodu: {ex}");
}
finally
{
    Console.WriteLine("İşlem başarıyla tamamlandı.");
}





Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();
