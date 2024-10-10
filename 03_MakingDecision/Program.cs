using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF-Else BLOĞU

            //Console.Write("Lutfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru.");
            //}
            //else {
            //    Console.WriteLine("Şİfre yanlış,tekrar deneyin. ");
            //        }

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ulkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "turkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else {
            //    Console.WriteLine("hatalı bilgi. ");
            //}

            //int sayi;
            //Console.Write("sayi giriniz: ");

            //sayi =int.Parse(Console.ReadLine());

            //if (sayi == 5)
            //{
            //    Console.WriteLine("sayı doğru ");
            //}

            //else
            //{

            //    Console.WriteLine("sayı hatalı ");
            //}

            //int exam1, exam2, exam3, average;
            //string result="hata";

            //Console.Write("sınav 1: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average=(exam1+exam2+exam3)/3;
            //Console.WriteLine("sınavların ortalama: " +  average);

            //if (average >0 & average<=50) 
            //{
            //    result = "sonuç vasat";

            //}
            //if (average >50 & average<=70)
            //{
            //    result = "sonuç ortalama";

            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç iyi";

            //}
            //if(average >84)
            //{
            //    result = "sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("lutfen şehir giriniz: ");
            //city=Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon") 
            //{
            //    Console.WriteLine("şehir mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}



            #endregion

            #region MOD İŞLEMLERİ

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("lutfen 1.sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("lutfen 2.sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());  

            //int result= number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölumunden kalan: " + result);

            //Console.Write("sayı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir. ");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir. ");
            //}
            #endregion

            #region char değişkenler ile karar yapıları
            //char team;
            //Console.Write("lutfen takım başharfini giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if (team =='b' | team=='B')
            //{
            //    Console.WriteLine("BEŞİKTAŞ ");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("FENERBAHÇE ");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("GALATAARAY ");
            //}

            #endregion

            #region örnek proje uygulama


            //Console.WriteLine("***** C# EĞİTİM KAMPI REsTORAN ***** ");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemekler ");
            //Console.WriteLine("2-Pizza ");
            //Console.WriteLine("3-Çorbalar ");
            //Console.WriteLine("4-İçecekler ");
            //Console.WriteLine("5-Tatlılar ");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();
            //string menuItem;

            //Console.Write("detayını görmwk istediğiniz menu seçimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem=="1")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("------------------ANA YEMEKLER--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Körili Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye-Pilav");
            //    Console.WriteLine();
            //}


            //if (menuItem == "2")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("------------------PİZZALAR--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita Pizza");
            //    Console.WriteLine("2-Karışık Pizza");
            //    Console.WriteLine("3-Vejeteryan Pizza");
            //    Console.WriteLine();
            //}


            //if (menuItem == "3")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("------------------ÇORBALAR--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine();
            //}


            //if (menuItem == "4")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("------------------İÇECEKLER--------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-su");
            //    Console.WriteLine();
            //}


            //if (menuItem == "5")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("------------------TATLILAR-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Şöbiyet");
            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{ 
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}


            #endregion


            Console.Read();
        }
    }
}
