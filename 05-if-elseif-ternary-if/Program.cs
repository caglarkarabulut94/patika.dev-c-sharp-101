string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   05-if-elseif-ternary-if    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("05-if-elseif-ternary-if");
Console.WriteLine(title);



int time = DateTime.Now.Hour;  // Saat Bilgisi İnterger olarak döner. 12:56 ise sadece 12 döner.

if (time >= 6 && time < 11)
    Console.WriteLine("Günaydın");

else if (time <= 18)
    Console.WriteLine("İyi Günler!");

else
    Console.WriteLine("İyi Geceler");


string sonuc = time <= 18 ? "İyi Günler" : "İyi Geceler";   // tek satır if else 2 li

sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler"; // tek satır if elseif else 3 lü 

Console.WriteLine(sonuc);

System.Console.WriteLine();

















Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();
