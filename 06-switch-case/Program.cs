string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   06-switch-case    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("06-switch-case");
Console.WriteLine(title);





int month = DateTime.Now.Month;

//Expression
switch (month)
{
    case 1:
        System.Console.WriteLine("Ocak Ayındasınız.");
        break;
    case 2:
        System.Console.WriteLine("Şubat Ayındasınız.");
        break;
    case 3:
        System.Console.WriteLine("Mart Ayındasınız.");
        break;
    default:
        System.Console.WriteLine("Acaba hangi aydasınız?");
        break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        System.Console.WriteLine("Kış mevsimindesiniz.");
        break;

    case 3:
    case 4:
    case 5:
        System.Console.WriteLine("İlkbahar mevsimindesiniz.");
        break;

    case 6:
    case 7:
    case 8:
        System.Console.WriteLine("Yaz mevsimindesiniz.");
        break;

    default:   // hiçbir şarta uydmadığı durum
        System.Console.WriteLine("Sonbahar Mevsimindesiniz.");
        break;
}





Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();