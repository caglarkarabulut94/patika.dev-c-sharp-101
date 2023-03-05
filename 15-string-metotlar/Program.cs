
string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   15-string-metotlar    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("15-string-metotlar");
Console.WriteLine(title);


string degisken = "Dersimiz C-Sharp Hoşgeldiniz";
Console.WriteLine("degisken: " + degisken);
string degisken2 = "C-Sharp";

// Karakter sayısı
Console.WriteLine("Karakter sayısı: " + degisken.Length);

// ToUpper, ToLower
Console.WriteLine("ToUpper: " + degisken.ToUpper());
Console.WriteLine("ToLower: " + degisken.ToLower());

// Concat (Birleştirme yapar)  // degisken1 = degisken2 + degisken3; kodu da aynı işi görüyor.
Console.WriteLine("Concat (Birleştirme yapar): " + String.Concat(degisken, " Merhaba"));

// Compare , CompareTo (karakter sayısı karşılaştırmak için kullanılır)
Console.WriteLine(degisken.CompareTo("Dersimiz C-Sharp"));
// karakter sayısı eşit ise = 0
// karakter sayısı olarak büyük ise = 1
// küçük ise = -1 döndürür    


Console.WriteLine(string.Compare(degisken, "Dersimiz C-Sharp", false));
// true dersek büyük-küçük harf duyarsızdır
// false dersek duyarlıdır


// Contains (İçinde var mı?)
Console.WriteLine(degisken.Contains(degisken2));

// Değişken "Hoşgeldiniz" ile bitiyor mu ?
Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));

// Değişken "Dersimiz" ile başlıyor mu ?
Console.WriteLine(degisken.StartsWith("Dersimiz"));

// IndexOf (Aradığımız ifadenin indeksini döner, ifade yoksa -1 döner)
Console.WriteLine(degisken.IndexOf("C-S"));
// En sondaki, belirttiğimiz ifadenin indeksini döndürür
Console.WriteLine(degisken.LastIndexOf("i"));

// Insert (Belirttiğimiz indeksten başlayarak ifadeyi ekler)
Console.WriteLine(degisken.Insert(0, "Merhaba"));

// PadLeft, PadRight
// (degisken2 nin karakter sayısını 30 a tamamlayacak kadar soldan boşluk ekle)
Console.WriteLine(degisken + degisken2.PadLeft(30));
// (Aynı şekilde degisken'in karakter sayısını 50 ye tamamlayana kadar sağdan * ekle)
Console.WriteLine(degisken.PadRight(50, '*') + degisken2);

// Remove 
// (Belirttiğimiz indeks ve aralıkta karakter silme yapar)
Console.WriteLine(degisken.Remove(5, 4));
Console.WriteLine(degisken.Remove(5));  // 5 den sonrasını sil

// Replace (Değiştir)
Console.WriteLine(degisken.Replace("C-Sharp", "C#"));
Console.WriteLine(degisken.Replace(" ", "_"));

// Split  (Boşluklara göre parçala ve bir diziye ata)
// Ve 1. indeksi getir, neye göre parçalayacağını biz belirleriz
Console.WriteLine(degisken.Split(' ')[1]);

// Substring , (belirlediğimiz indeksten başlayarak cümlenin sonuna kadar götürür)
Console.WriteLine(degisken.Substring(4));  // 4 den öncesini sil gibi 
// Belirlediğimiz karakter kadar getir
Console.WriteLine(degisken.Substring(4, 6));





Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();