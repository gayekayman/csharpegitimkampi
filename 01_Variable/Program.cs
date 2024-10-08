using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkenler
            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("******fiyat listesi*****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice); 
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice); 
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice); 
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice); 
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice); 

            //double appleGram,orangeGram, strawberryGram , potatoGram , tomatoGram ;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //Console.WriteLine("Alınan Urun :Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " +appleGram + "- Toplam tutar: " + appleTotalPrice);
            //double orangeTotalPrice = orangePrice * orangeGram;
            //Console.WriteLine("Alınan Urun :Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + "- Toplam tutar: " + orangeTotalPrice);
            //double strawTotalPrice = strawberryPrice * strawberryGram;
            //Console.WriteLine("Alınan Urun :Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + "- Toplam tutar: " + strawTotalPrice);
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //Console.WriteLine("Alınan Urun :Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + "- Toplam tutar: " + potatoTotalPrice);
            //double tomatoTotalPrice= tomatoPrice * tomatoGram;
            //Console.WriteLine("Alınan Urun :Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + "- Toplam tutar: " + tomatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine();


            //Console.WriteLine("Ödemeniz gereken toplam tutar: " + (appleTotalPrice + orangeTotalPrice + strawTotalPrice 
            //    + potatoTotalPrice + tomatoTotalPrice));

            #endregion

            #region CHAR DEĞİŞKENLER
            //char symbol = 'a';
            //Console.WriteLine(symbol);



            #endregion

            #region Klavyeden Veri Girişleri string Değişkenler
            //Console.WriteLine(" **** Gaye Havayolları Yolcu Bilgisi **** ");
            //string passengerName, passengersurname, passengerDistrict, passengerCity, passengerAge,
            //passengerIdentıtyNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı: ");
            //passengersurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC Kimlik No: ");
            //passengerIdentıtyNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No:" + passengerIdentıtyNumber + " -Yolcu Bilgileri: " + passengerName + " " + passengersurname + " " + passengerDistrict + " / " 
            //    + passengerCity +" " + passengerAge );



            #endregion

            #region Veri Girişleri Tamsayı Girişleri ve DÖNUŞUMLER

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız Pc sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;
            //Console.WriteLine();

            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);

            #endregion

            #region Klavyeden Karakter Girişleri 

            //char gender;
            //Console.Write("Ltfen Cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("seçtiğiniz cinsiyet: "+ gender);
            
            #endregion

            Console.Read();
        }
    }
}
