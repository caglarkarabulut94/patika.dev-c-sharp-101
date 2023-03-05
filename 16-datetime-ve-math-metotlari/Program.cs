string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   16-datetime-ve-math-metotlari    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("16-datetime-ve-math-metotlari");
Console.WriteLine(title);


string baslik01 = @"
---------------------------------------------------------------------------------------------------------
                                            DateTime metotları                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik01}\n");




Console.WriteLine(DateTime.Now);  // 6.03.2023 00:12:58
Console.WriteLine(DateTime.Now.Date); // 6.03.2023 00:00:00
Console.WriteLine(DateTime.Now.Day); // 6
Console.WriteLine(DateTime.Now.Month); // 3
Console.WriteLine(DateTime.Now.Year); // 2023
Console.WriteLine(DateTime.Now.Hour); // 0
Console.WriteLine(DateTime.Now.Minute); // 12
Console.WriteLine(DateTime.Now.Second); // 58

Console.WriteLine(DateTime.Now.DayOfWeek); // Monday

var culture = new System.Globalization.CultureInfo("tr-TR");  // sistem diline göre 
Console.WriteLine(culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek)); // Pazartesi

Console.WriteLine(DateTime.Now.DayOfYear); // 65

Console.WriteLine(DateTime.Now.ToLongDateString()); // 6 Mart 2023 Pazartesi
Console.WriteLine(DateTime.Now.ToShortDateString()); // 6.03.2023
Console.WriteLine(DateTime.Now.ToLongTimeString()); // 00:12:58
Console.WriteLine(DateTime.Now.ToShortTimeString()); // 00:12

Console.WriteLine(DateTime.Now.AddDays(2)); // 8.03.2023 00:12:58
Console.WriteLine(DateTime.Now.AddHours(3)); // 6.03.2023 03:12:58
Console.WriteLine(DateTime.Now.AddSeconds(20)); // 6.03.2023 00:13:18
Console.WriteLine(DateTime.Now.AddMonths(1)); // 6.04.2023 00:12:58
Console.WriteLine(DateTime.Now.AddYears(2)); // 6.03.2025 00:12:58
Console.WriteLine(DateTime.Now.AddMilliseconds(55)); // 6.03.2023 00:12:58

// 8.03.2023
Console.WriteLine(DateTime.Now.ToString("dd")); // 06
Console.WriteLine(DateTime.Now.ToString("ddd")); // Pzt
Console.WriteLine(DateTime.Now.ToString("dddd")); // Pazartesi

Console.WriteLine(DateTime.Now.ToString("MM")); // 03
Console.WriteLine(DateTime.Now.ToString("MMM")); // Mar
Console.WriteLine(DateTime.Now.ToString("MMMM")); // Mart

Console.WriteLine(DateTime.Now.ToString("yy")); // 23
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2023




string baslik02 = @"
---------------------------------------------------------------------------------------------------------
                                            Math metotları                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik02}\n");

Console.WriteLine(Math.Abs(-25)); // mutlak değer
Console.WriteLine(Math.Sin(10));  // sinüs 
Console.WriteLine(Math.Cos(10));  // cosinüs
Console.WriteLine(Math.Tan(10));  //tanjant

Console.WriteLine(Math.Ceiling(22.3)); // 23 /yukarı yuvarla
Console.WriteLine(Math.Round(22.3)); // 22 /yuvarla /0,5 den küçük old. için aşağı
Console.WriteLine(Math.Round(22.7)); // 23 /yuvarla /0,5 den büyük old. için yukarı
Console.WriteLine(Math.Floor(22.7)); // 22 /aşağı yuvarla

Console.WriteLine(Math.Max(2, 6)); // verilenler arasında en büyüğü verir
Console.WriteLine(Math.Min(2, 6)); // verilenler arasında en küçüğü verir

Console.WriteLine(Math.Pow(3, 4)); // 3 üssü 4 = 81
Console.WriteLine(Math.Sqrt(9)); // karekök 9 = 3
Console.WriteLine(Math.Log(9)); // 9 un e tabanındai logaritmik karşılığı
Console.WriteLine(Math.Exp(3)); // e üssü 3
Console.WriteLine(Math.Log10(10)); // 10 sayısının log10 tabanında karşılığı






Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();