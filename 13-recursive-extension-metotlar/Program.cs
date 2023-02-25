string title = @"
   ____            _            _  __               _           _       _                             
  / ___|__ _  __ _| | __ _ _ __| |/ /__ _ _ __ __ _| |__  _   _| |_   _| |_        ___ ___  _ __ ___  
 | |   / _` |/ _` | |/ _` | '__| ' // _` | '__/ _` | '_ \| | | | | | | | __|      / __/ _ \| '_ ` _ \ 
 | |__| (_| | (_| | | (_| | |  | . \ (_| | | | (_| | |_) | |_| | | |_| | |_   _  | (_| (_) | | | | | |
  \____\__,_|\__, |_|\__,_|_|  |_|\_\__,_|_|  \__,_|_.__/ \__,_|_|\__,_|\__| (_)  \___\___/|_| |_| |_|
             |___/                                                                                    
                                                                         
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   13-recursive-extension-metotlar    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
";
Console.Title = ("13-recursive-extension-metotlar");
Console.WriteLine(title);






string baslik01 = @"
---------------------------------------------------------------------------------------------------------
                                            Rekürsif  - Öz yineleme                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik01}\n");

Console.WriteLine($"3^4 (3 üssü 4):  \n");
int result = 1;

for (int i = 1; i < 5; i++)
{
    result = result * 3;
}
Console.WriteLine($"for döngüsüyle sonuc: {result}  \n");



Islemler islemler = new Islemler();
Console.Write($"Expo metotu ile sonuc:  ");
Console.WriteLine($" = {islemler.Expo(3, 4)}  \n");



Console.WriteLine($"Faktöriyel alınacak sayıyı girin:");
int fakt = int.Parse(Console.ReadLine());
Console.WriteLine($" = {islemler.Faktoriyel(fakt)}  \n");



string baslik02 = @"
---------------------------------------------------------------------------------------------------------
                                            Extension Metotlar                                                
---------------------------------------------------------------------------------------------------------";
Console.WriteLine($"\n\n\n\n\n{baslik02}\n");

string ifade = "Çağlar KARABULUT";
bool sonuc = ifade.CheckSpaces();
if (sonuc)
    Console.WriteLine(ifade.RemoveWhiteSpaces());

Console.WriteLine(ifade.MakeUpperCase());
Console.WriteLine(ifade.MakeLoweCase());


int[] dizi = { 9, 3, 4, 2, 5, 0, 1 };
dizi.SortArray();
dizi.EkranaYazdır();

int sayi = 5;
Console.WriteLine(sayi.ciftSayiMi());  // 

Console.WriteLine(ifade.ilkHarfiniGetir());






Console.WriteLine("\n\n\n\n\n\n\n Çıkmak için Enter.");
Console.ReadKey();



public class Islemler
{
    public int Expo(int sayi, int us)
    {
        string sonifade = us == 1 ? "" : " * ";
        Console.Write($"{sayi}{sonifade}");

        if (us <= 1)       // 1 üzeri x = 1 dir.
            return sayi;

        return Expo(sayi, us - 1) * sayi;
        // Expo(3,4)       başta gelen istek
        // Expo(3,3) * 3    ilk aşama
        // Expo(3,2) * 3 * 3    ikinci aşama
        // Expo(3,1) * 3 * 3 * 3    üçüncü aşama artık üs 1 olduğuna göre Expo(3,1) if döngüsüne girip sonuc 3 dönecek
        //     3     * 3 * 3 * 3    = 81 return olacak 

    }

    public int Faktoriyel(int sayi2)
    {
        string sonifade = sayi2 == 1 ? "" : " * ";
        Console.Write($"{sayi2}{sonifade}");

        if (sayi2 <= 1)       // 
            return sayi2;

        return Faktoriyel(sayi2 - 1) * sayi2;
        // Faktoriyel(5)   başta gelen istek
        // Faktoriyel(5-1) * 4  ilk aşama = 20
        // Faktoriyel(4-1) * 20   ikinci aşama = 60
        // Faktoriyel(3-1) * 60   üçüncü aşama = 120
    }

}



public static class ExtensionMetotlar
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLoweCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void EkranaYazdır(this int[] param)
    {
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }
    public static bool ciftSayiMi(this int param)
    {
        return param % 2 == 0;  // mod2 si 0 çıkarsa true dönecek
    }
    public static string ilkHarfiniGetir(this string param)
    {
        return param.Substring(0, 1);
    }


}








